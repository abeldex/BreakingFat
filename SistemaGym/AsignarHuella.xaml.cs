using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using DPUruNet;


namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for AsignarHuella.xaml
    /// </summary>
    public partial class AsignarHuella : Window
    {
        PersonalUAU.DigitalPersona objMethods;
        Reader objReader;
        string xml;
        List<PersonalUAU.Clases.Persona> listPerson;
        private object cliente;
        string cs  = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;

        public AsignarHuella()
        {
            InitializeComponent();
            objMethods = new PersonalUAU.DigitalPersona();

            //For one device detected by the computer
            objReader = objMethods.GetDevice();
           
        }

        public AsignarHuella(object cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            AppData data = new AppData(Convert.ToInt32(cliente));
            objMethods = new PersonalUAU.DigitalPersona();

            //For one device detected by the computer
            objReader = objMethods.GetDevice();
            InitializeObjects();
        }

        private void InitializeObjects()
        {
            listPerson = new List<PersonalUAU.Clases.Persona>();
        }

        private void btm_actualizar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            objMethods.ShowWindowEnrollment(objReader);
            xml = objMethods.GetFingerprint_XML();
            //registrar en la base de datos
            try
            {
                //insertamos en la base de datos
                SqlConnection conexion = new SqlConnection(cs);
                conexion.Open();
                string comando = "IF EXISTS (SELECT 1 FROM GYM.Huellas WHERE cod_cliente=" + cliente + ")" +
                                " BEGIN " +
                                " UPDATE GYM.Huellas SET Huella = '" + xml + "' WHERE cod_cliente = '" + cliente + "'" +
                                " END " +
                                " ELSE " +
                                " BEGIN " +
                                " INSERT INTO GYM.Huellas VALUES (" + cliente + ",0,'" + xml + "')" +
                                " END ";
                SqlCommand query = new SqlCommand(comando, conexion);

                //SqlCommand query2 = new SqlCommand("update cliente set EnrolledFingerMask = " + EnrollmentControl.EnrolledFingerMask + " where cod_cliente = " + cliente, conexion);
                query.ExecuteNonQuery();
                //query2.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_identificar_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }

    

}
