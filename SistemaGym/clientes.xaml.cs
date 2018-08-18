using Negocios;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using DPUruNet;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using MaterialDesignThemes.Wpf;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Imaging;
using Microsoft.Win32;
using Datos;

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for clientes.xaml
    /// </summary>
    public partial class clientes
    {
        public int codigo;
        PersonalUAU.DigitalPersona objMethods;
        Reader objReader;
        string xml;
        List<PersonalUAU.Clases.Persona> listPerson;
        string cs = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;

        public clientes()
        {
            InitializeComponent();
            ListarBuscar("");
            dg_clientes.Items.Refresh();
            objMethods = new PersonalUAU.DigitalPersona();

            //For one device detected by the computer
            objReader = objMethods.GetDevice();
            InitializeObjects();
        }

        private void InitializeObjects()
        {
            listPerson = new List<PersonalUAU.Clases.Persona>();
        }

        //metodo para buscar un usuario por usuario
        public void ListarBuscar(string dato)
        {
            try
            {
                dg_clientes.ItemsSource = new Nclientes().ListarClientes(dato);
                dg_clientes.Items.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_huella_Click(object sender, RoutedEventArgs e)
        {
            //obtenemos el usuario desde el datagrid por medio de la fila seleccionada
            object Cliente = ((Button)sender).CommandParameter;
            //mandamos un mensaje para preguntar si deseamos eliminar
            MessageBoxResult result = MessageBox.Show("Desea capturar la huella del cliente: " + Cliente + "", "Capturar Huella", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                registrar_huella(Convert.ToInt32(Cliente));
            }
        }

        private void registrar_huella(int Cliente)
        {
            try
            {
                //AsignarHuella ah = new AsignarHuella(Cliente);
                AppData data = new AppData(Cliente);
                //AsignarHuella ah = new AsignarHuella(Cliente);
                //ah.Show();
                objMethods.ShowWindowEnrollment(objReader);
                xml = objMethods.GetFingerprint_XML();
                //insertamos en la base de datos
                /*SqlConnection conexion = new SqlConnection(cs);
                conexion.Open();
                SqlCommand query = new SqlCommand("INSERT INTO GYM.Huellas VALUES (" + Cliente + ",0,'" + xml + "')", conexion);
                query.ExecuteNonQuery();
                conexion.Close();*/
                SqlConnection conexion = new SqlConnection(cs);
                conexion.Open();
                string comando = "IF EXISTS (SELECT 1 FROM GYM.Huellas WHERE cod_cliente=" + Cliente + ")" +
                                 " BEGIN " +
                                 " UPDATE GYM.Huellas SET Huella = '" + xml + "' WHERE cod_cliente = '" + Cliente + "'" +
                                 " END " +
                                 " ELSE " +
                                 " BEGIN " +
                                 " INSERT INTO GYM.Huellas VALUES (" + Cliente + ",0,'" + xml + "')" +
                                 " END ";
                SqlCommand query = new SqlCommand(comando, conexion);

                //SqlCommand query2 = new SqlCommand("update cliente set EnrolledFingerMask = " + EnrollmentControl.EnrolledFingerMask + " where cod_cliente = " + cliente, conexion);
                query.ExecuteNonQuery();
                //query2.ExecuteNonQuery();
                conexion.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //obtenemos los valores de los texbox y los mandamos a la entidad cliente
                entidad_clientes c1 = new entidad_clientes
                {
                    CLIENTE_NOMBRE = txt_nombre.Text,
                    CLIENTE_DIRECCION = txt_direccion.Text,
                    CLIENTE_CIUDAD = txt_ciudad.Text,
                    CLIENTE_TELEFONO = txt_telefono.Text,
                    CLIENTE_SEXO = ((ComboBoxItem)cmb_sexo.SelectedItem).Tag.ToString(),
                    CLIENTE_CORREO = txt_correo.Text,
                    CLIENTE_FECHA_NAC = DateTime.Now,
                    HUELLA = 0

                };
                //insertamos el registro
                codigo = new Nclientes().Insertar(c1);
                //ListarBuscar(txt_nombre.Text);
                MessageBox.Show("Cliente Registrado Correctamente");
               /* MessageBoxResult result = MessageBox.Show("Desea Capturar la huella del cliente: " + txt_nombre.Text + "", "Capturar Huella", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    //AsignarHuella ah = new AsignarHuella(codigo);
                    //ah.Show();
                    registrar_huella(codigo);
                }*/
              
                limpiartext();
                ListarBuscar("");
            }
            catch
            {
                MessageBox.Show("Error, No se guardo su registro");
            }

        }

        private void txt_buscar_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ListarBuscar(txt_buscar.Text);
        }

        private void btm_actualizar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_membresia_Click(object sender, RoutedEventArgs e)
        {
            //obtenemos el usuario desde el datagrid por medio de la fila seleccionada
            object Cliente = ((Button)sender).CommandParameter;
            //mandamos un mensaje para preguntar si deseamos eliminar
            MessageBoxResult result = MessageBox.Show("Desea registrar una membresia a el cliente: " + Cliente + "", "Registrar Membresias", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Membresias mm = new Membresias(Convert.ToInt32(Cliente));
                    mm.Show();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            //obtenemos el usuario desde el datagrid por medio de la fila seleccionada
            object Cliente = ((Button)sender).CommandParameter;
            //mandamos un mensaje para preguntar si deseamos eliminar
            MessageBoxResult result = MessageBox.Show("Realmente desea eliminar el cliente " + Cliente.ToString() + " ?", "Piense", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    new Nclientes().Eliminar(Convert.ToInt32(Cliente));
                    ListarBuscar("");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        int cliente_act;

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {

            //Datos.VistaClientes cln = dg_clientes.SelectedItem as Datos.VistaClientes;
            //MessageBox.Show(cln.NOMBRE);

            /*entidad_clientes ec = new entidad_clientes();
            ec = new Nclientes().GetDatosPersonales(cln.COD);
            cliente_act = cln.COD;
            txt_nombre.Text = ec.CLIENTE_NOMBRE;
            txt_direccion.Text = ec.CLIENTE_DIRECCION;
            txt_correo.Text = ec.CLIENTE_CORREO;
            txt_telefono.Text = ec.CLIENTE_TELEFONO;
            txt_ciudad.Text = ec.CLIENTE_CIUDAD;
            if (ec.CLIENTE_SEXO == "Masculino")
                cmb_sexo.SelectedIndex = 1;
            else
                cmb_sexo.SelectedIndex = 2;

            btn_guardar.Visibility = Visibility.Hidden;
            btn_actualizar.Visibility = Visibility.Visible;*/
        }

        private void limpiartext()
        {
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_ciudad.Text = "";
            cmb_sexo.SelectedIndex = -1;
        }

        private void btn_actualizar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                entidad_clientes ec = new entidad_clientes();
                ec.CLIENTE_COD_CLIENTE = cliente_act;
                ec.CLIENTE_NOMBRE = txt_nombre.Text;
                ec.CLIENTE_CORREO = txt_correo.Text;
                ec.CLIENTE_TELEFONO = txt_telefono.Text;
                ec.CLIENTE_DIRECCION = txt_direccion.Text;
                ec.CLIENTE_CIUDAD = txt_ciudad.Text;
                ec.CLIENTE_SEXO = ((ComboBoxItem)cmb_sexo.SelectedItem).Tag.ToString();
                ec.CLIENTE_FECHA_NAC = DateTime.Now;
                new Nclientes().Editar(ec);

                btn_guardar.Visibility = Visibility.Visible;
                btn_actualizar.Visibility = Visibility.Hidden;
                ListarBuscar("");
                limpiartext();
                MessageBox.Show("Cliente Actualizado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error, No se actualizo su registro" + err.Message);
            }

        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            limpiartext();
            btn_guardar.Visibility = Visibility.Visible;
            btn_actualizar.Visibility = Visibility.Hidden;
        }

        private void PDF()
        {
            string pdfpath = "";

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "PDF Files(*.pdf)|*.pdf|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                try
                {
                    pdfpath = dialog.FileName;
                    //Step 1: Create a System.IO.FileStream object:
                    FileStream fs = new FileStream(pdfpath, FileMode.Create, FileAccess.Write, FileShare.None);
                    //Definimos el tamaño de la hoja del reporte
                    //Rectangle rectangulo = new Rectangle(PageSize.LETTER.Rotate());
                    //Step 2: Create a iTextSharp.text.Document object:
                    //Document doc = new Document();
                    var doc = new Document(PageSize.LETTER, 10, 10, 10, 10);
                    //Establecemos el titulo del documento
                    doc.AddTitle(dialog.SafeFileName);
                    //Step 3: Create a iTextSharp.text.pdf.PdfWriter object. It helps to write the Document to the Specified FileStream:
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    //Step 4: Openning the Document:
                    doc.Open();
                    //agregar imagen del logo
                    //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Directory.GetCurrentDirectory() + "\\imagenes\\logoMuscle.png");
                    //doc.Add(logo);
                    //Step 5: Adding a Paragraph by creating a iTextSharp.text.Paragraph object:
                    //doc.Add(new Paragraph("Hola Mundo"));
                    //aregamos el logo

                    var logo = iTextSharp.text.Image.GetInstance(ConfigurationManager.AppSettings.Get("logo"));
                    //logo.ScalePercent(6f);
                    logo.ScaleAbsolute(159f, 159f);
                    logo.SetAbsolutePosition(doc.PageSize.Width - 180f, doc.PageSize.Height - 180f);
                    doc.Add(logo);

                    var titleFont = FontFactory.GetFont("Arial", 18, Font.BOLD);
                    var subTitleFont = FontFactory.GetFont("Arial", 14, Font.BOLD);
                    var boldTableFont = FontFactory.GetFont("Arial", 12, Font.BOLD);
                    var endingMessageFont = FontFactory.GetFont("Arial", 10, Font.ITALIC);
                    var bodyFont = FontFactory.GetFont("Arial", 12, Font.NORMAL);

                    //el Titulo aqui
                    doc.Add(new Paragraph("Reporte de Prueba 1", titleFont));
                    //agregamos los detalles
                    List<VistaClientes> clis;
                    clis = new Nclientes().ListarClientes("");
                    var orderInfoTable = new PdfPTable(4);
                    orderInfoTable.HorizontalAlignment = 0;
                    orderInfoTable.SpacingBefore = 10;
                    orderInfoTable.SpacingAfter = 10;
                    orderInfoTable.DefaultCell.Border = 0;
                    //orderInfoTable.SetWidths(new int[] { 1, 4 });
                    foreach (VistaClientes c in clis)
                    {
                        orderInfoTable.AddCell(new Phrase(c.COD.ToString(), boldTableFont));
                        orderInfoTable.AddCell(c.NOMBRE);
                        orderInfoTable.AddCell(c.TELEFONO);
                        orderInfoTable.AddCell(c.CORREO);
                    }
                    doc.Add(orderInfoTable);

                    //Step 6: Closing the Document:
                    doc.Close();
                    writer.Close();
                    fs.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
               
            }
        }

        public void GenerarReporteClientes()
        {

            var doc = new Document(PageSize.LETTER, 10f, 10f, 120f, 100f);

            string strFilePath = "";

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "PDF Files(*.pdf)|*.pdf|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                strFilePath = dialog.FileName;
            }

                var fileName = "Pdf_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".pdf";

            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.UNDERLINE, BaseColor.BLACK);
            var h1Font = FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD);
            var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.NORMAL, BaseColor.DARK_GRAY);

            try
            {
                var pdfWriter = PdfWriter.GetInstance(doc, new FileStream(strFilePath + fileName, FileMode.Create));
                pdfWriter.PageEvent = new ITextEvents();
                doc.Open();

                var tblContainer = new PdfPTable(4) { TotalWidth = 520f, LockedWidth = true };
                float[] widths = { 90f, 150f, 120f, 110f};
                tblContainer.SetWidths(widths);
                var heading = new Phrase("Reporte de Clientes Registrados.\n\n", h1Font);
                var titleCOD = new Phrase("COD", titleFont);
                var titleNOM = new Phrase("NOMBRE", titleFont);
                var titleTEL = new Phrase("TELEFONO", titleFont);
                var titleMAIL = new Phrase("CORREO", titleFont);
                var cellTicketName = new PdfPCell(heading) { Colspan = 4, Border = 0 };
                var cellTitleCOD = new PdfPCell(titleCOD);
                var cellTitleNOM = new PdfPCell(titleNOM);
                var cellTitleTEL = new PdfPCell(titleTEL);
                var cellTitleMAIL = new PdfPCell(titleMAIL);

                cellTitleCOD.Border = 0;
                cellTitleNOM.Border = 0;
                cellTitleTEL.Border = 0;
                cellTitleMAIL.Border = 0;

                tblContainer.AddCell(cellTicketName);
                tblContainer.AddCell(new PdfPCell(new Phrase("")) { Colspan = 4, Border = 0 });

                tblContainer.AddCell(cellTitleCOD);
                tblContainer.AddCell(cellTitleNOM);
                tblContainer.AddCell(cellTitleTEL);
                tblContainer.AddCell(cellTitleMAIL);

                doc.Add(tblContainer);

                //agregamos los datos de la tabla de clientes
                //agregamos los detalles
                List<VistaClientes> clis;
                clis = new Nclientes().ListarClientes("");
                var tblResult = new PdfPTable(4) { TotalWidth = 520f, LockedWidth = true };
                tblResult.SetWidths(widths);

                foreach (VistaClientes c in clis)
                {
                    
                    var cod = new Phrase(c.COD.ToString(), bodyFont);
                    var nombre = new Phrase(c.NOMBRE, bodyFont);
                    var telefono = new Phrase(c.TELEFONO, bodyFont);
                    var email = new Phrase(c.CORREO, bodyFont);


                    var cellCOD = new PdfPCell(cod);
                    var cellNOM = new PdfPCell(nombre);
                    var cellTEL = new PdfPCell(telefono);
                    var cellMAIL = new PdfPCell(email);

                    cellCOD.Border = 0;
                    cellNOM.Border = 0;
                    cellTEL.Border = 0;
                    cellMAIL.Border = 0;

                    tblResult.AddCell(cellCOD);
                    tblResult.AddCell(cellNOM);
                    tblResult.AddCell(cellTEL);
                    tblResult.AddCell(cellMAIL);

                    
                }
                doc.Add(tblResult);
                doc.Close();

                byte[] contents = System.IO.File.ReadAllBytes(strFilePath + fileName);
                Uri uri = new Uri(strFilePath + fileName);
                PDFView pdf = new PDFView(uri);
                pdf.Show();
                pdf.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                pdf.WindowState = WindowState.Maximized;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private void btn_imprimir_Click(object sender, RoutedEventArgs e)
        {
            GenerarReporteClientes();
        }

        private void btn_nuevo_Click(object sender, RoutedEventArgs e)
        {

            nuevo_cliente formObject = new nuevo_cliente();
            //formObject.ShowDialog();
            formObject.ShowDialog();
            string result = formObject.Response;
            //to update response of form2 after saving in result
            formObject.Response = "";
            //MessageBox.Show("Response from form2: " + result);
            //QuitarEfecto(this);
            if (result == "ok")
            {
                ListarBuscar("");
               // AplicarEfecto(this);
                
            }
               


        }

        private void AplicarEfecto(Window win)
        {
            var objBlur = new System.Windows.Media.Effects.BlurEffect();
            objBlur.Radius = 5;
            win.Effect = objBlur;
        }

        private void QuitarEfecto(Window win)
        {
            win.Effect = null;
        }

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            //obtenemos el usuario desde el datagrid por medio de la fila seleccionada
            object Cliente = ((Button)sender).CommandParameter;
            Vclientes.Perfil perfil = new Vclientes.Perfil(Cliente);
            perfil.Show();
        }
    }
   
}
