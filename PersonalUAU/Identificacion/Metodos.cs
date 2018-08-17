using DPUruNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalUAU.Identificacion
{
    public class Metodos
    {
        private const int DPFJ_PROBABILITY_ONE = 0x7fffffff;
        private Thread identifyThreadHandle;
        private bool reset = false;
        Reader objReader;
        PersonalUAU.DigitalPersona objReaderMethods;
        PersonalUAU.SelectorHuella.Metodos objDeviceReader;
        //PersonalUAU.CapturaHuellaWPF.Metodos objCaptureWPF;
        List<Clases.Persona> listPersons;
        VistaIdentificacion menuPrincipal;

        public Metodos(Reader objReader,List<Clases.Persona> listPersons,VistaIdentificacion menuPrincipal)
        {
            this.objReader = objReader;
            this.listPersons = listPersons;
            this.menuPrincipal = menuPrincipal;
            InitializeObjects();
        }

        private void InitializeObjects()
        {
            objReaderMethods = new PersonalUAU.DigitalPersona();
            objDeviceReader = new SelectorHuella.Metodos();
            //objCaptureWPF = new PersonalUAU.CapturaHuellaWPF.Metodos(objReader,menuPrincipal.picHuella);
            //objCaptureWPF.StartCaptures();
        }

        public void StartIdentify()
        {
            //identifyThreadHandle = new Thread(() => IdentifyThread(buscarPersona));
            identifyThreadHandle = new Thread(IdentifyThread);
            identifyThreadHandle.IsBackground = true;
            identifyThreadHandle.Start();
        }

        private void IdentifyThread()
        {

            while (!reset)
            {
                Fid fid = null;

                if (!CaptureFinger(ref fid))
                {
                    //break;
                }

                if (objReader == null)
                {
                    objReader = objDeviceReader.IndexDevice();
                    objDeviceReader.InitializeDevice(ref objReader);
                }

                if (fid == null)
                {
                    continue;
                }

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(fid, Constants.Formats.Fmd.ANSI);
                

                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    //break;

                    if (objReader != null)
                    {
                        objReader.Dispose();
                        objReader = null;
                    }
                    return;
                }
                    
                int thresholdScore = DPFJ_PROBABILITY_ONE * 1 / 100000;

                Fmd aux = resultConversion.Data;
                Fmd temp;
                foreach (Clases.Persona item in listPersons)
                {
                    try
                    {
                        temp = Fmd.DeserializeXml(item.huella);

                        CompareResult identifyResult = Comparison.Compare(aux, 0, temp, 0);

                        if (identifyResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                        {
                            break;
                        }

                        if (identifyResult.Score < thresholdScore)
                        {   
                            List<Datos.membresia> mem = new Negocios.Nmembresia().ListarMembresia(item.id);
                            //guardar la asistencia en la base de datos
                            try
                            {
                                //insertamos en la base de datos
                                string cs = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;

                                SqlConnection conexion = new SqlConnection(cs);
                                conexion.Open();
                                SqlCommand query = new SqlCommand("INSERT INTO GYM.asistencias VALUES (" + item.id + ", GETDATE())", conexion);
                                query.ExecuteNonQuery();
                                conexion.Close();
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }

                            if (mem.Count > 0)
                            {
                                string membresia = "";
                                DateTime fecha_i = DateTime.Now;
                                DateTime fecha_f = DateTime.Now;
                                foreach (var m in mem)
                                {
                                    //sacamos el tipo de membresia
                                    switch (m.tipo_membresia)
                                    {
                                        case "G": membresia = "Gimnasio"; break;
                                        case "Z": membresia = "Zumba"; break;
                                        case "C": membresia = "Crossfit"; break;
                                    }
                                    //sacamos la fecha inicial
                                }

                                // Difference in days, hours, and minutes.
                                TimeSpan ts = fecha_f - DateTime.Now;

                                // Difference in days.
                                int differenceInDays = ts.Days;
                                SendMessage("Cliente identificado: ", item.Nombre, membresia, fecha_i.ToShortDateString(), fecha_f.ToShortDateString(), differenceInDays.ToString());
                            }
                            else
                            {
                                SendMessage("Cliente identificado: ", item.Nombre, "Sin Membresia Activa", "", "", "");
                            }
                            Thread.Sleep(10000);
                            SendMessage("Coloque el dedo en el checador...", "", "", "", "","");
                            menuPrincipal.Dispatcher.BeginInvoke(new Action(delegate ()
                            {
                                menuPrincipal.lblMembresia.Content = "";
                                menuPrincipal.lbl_inicio.Content = "";
                                menuPrincipal.lbl_fin.Content = "";
                                menuPrincipal.lbl_resto.Content = "";
                            }));
                            break;
                        }
                        /*else
                        {
                            SendMessage("No se encuentra registrada la huella capturada", "", "", "","","");
                            Thread.Sleep(2000);
                            SendMessage("Coloque el dedo en el checador...", "", "", "", "","");
                            break;
                        }*/
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    
                }
            }

            if (objReader != null)
                objReader.Dispose();
        }

        public bool CaptureFinger(ref Fid fid)
        {
            try
            {
                Constants.ResultCode result = objReader.GetStatus();

                if ((result != Constants.ResultCode.DP_SUCCESS))
                {
                    //MessageBox.Show("Get Status Error:  " + result);
                    if (objReader != null)
                    {
                        objReader.Dispose();
                        objReader = null;
                    }
                    return false;
                }

                if ((objReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_BUSY))
                {
                    Thread.Sleep(50);
                    return true;
                }
                else if ((objReader.Status.Status == Constants.ReaderStatuses.DP_STATUS_NEED_CALIBRATION))
                {
                    objReader.Calibrate();
                }
                else if ((objReader.Status.Status != Constants.ReaderStatuses.DP_STATUS_READY))
                {
                    //MessageBox.Show("Get Status:  " + Lector.Status.Status);

                    if (objReader != null)
                    {
                        objReader.Dispose();
                        objReader = null;
                    }
                    return false;
                }

                CaptureResult captureResult = objReader.Capture(Constants.Formats.Fid.ANSI, Constants.CaptureProcessing.DP_IMG_PROC_DEFAULT, 5000, objReader.Capabilities.Resolutions[0]);

                if (captureResult.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    //MessageBox.Show("Error:  " + captureResult.ResultCode);

                    if (objReader != null)
                    {
                        objReader.Dispose();
                        objReader = null;
                    }
                    return false;
                }

                if (captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_CANCELED)
                {
                    return false;
                }

                if ((captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_NO_FINGER || captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_TIMED_OUT))
                {
                    return true;
                }

                if ((captureResult.Quality == Constants.CaptureQuality.DP_QUALITY_FAKE_FINGER))
                {
                    //MessageBox.Show("Quality Error:  " + captureResult.Quality);

                    return true;
                }

                fid = captureResult.Data;

                return true;
            }
            catch
            {
                //MessageBox.Show("An error has occurred.");
                if (objReader != null)
                {
                    objReader.Dispose();
                    objReader = null;
                }
                return false;
            }
        }

        private delegate void SendMessageCallback(string payload);

        private void SendMessage(string payload, string nombre, string membresia, string fechai, string fechaf, string restantes)
        {
            menuPrincipal.Dispatcher.BeginInvoke(new Action(delegate()
            {
                menuPrincipal.lblMensaje.Content = payload;
                menuPrincipal.lblNombre.Content = nombre;
                menuPrincipal.lblMembresia.Content = "Inscrito en " + membresia;
                menuPrincipal.lbl_inicio.Content =  "Inicio: " + fechai;
                menuPrincipal.lbl_fin.Content =  "Termina: " + fechaf;
                menuPrincipal.lbl_resto.Content = "Restan " + restantes + " días";
            }));

        }

        public void StopIdentify()
        {
            if (objReader != null)
            {
                reset = true;
                objReader.CancelCapture();

                if (identifyThreadHandle != null)
                {
                    identifyThreadHandle.Join(5000);
                }
            }
            else
            {
                reset = true;
                if (identifyThreadHandle != null)
                {
                    identifyThreadHandle.Join(5000);
                }
            }
        }
    }
}
