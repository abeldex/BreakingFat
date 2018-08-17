using System.Windows;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DPUruNet;
using System.Collections.Generic;
using System;

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for VerChecador.xaml
    /// </summary>
    public partial class VerChecador : Window
    {
        PersonalUAU.DigitalPersona objMethods;
        Reader objReader;
        List<PersonalUAU.Clases.Persona> listPerson;
        string cs = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;

        public VerChecador()
        {
            InitializeComponent();
            //Checador ch = new Checador();
            //ch.TopLevel = false;
            //ch.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objMethods = new PersonalUAU.DigitalPersona();

            //For one device detected by the computer
            objReader = objMethods.GetDevice();
            InitializeObjects();
            Listar("");
        }

        private void InitializeObjects()
        {
            listPerson = new List<PersonalUAU.Clases.Persona>();
        }

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {
            Listar("");
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_checador_Click(object sender, RoutedEventArgs e)
        {
            //obtenemos las huellas de los clientes y los metemos a la clase de personas
            SqlConnection conexion = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select dbo.cliente.cod_cliente, Huella, nombre from GYM.Huellas inner join dbo.cliente on GYM.Huellas.cod_cliente = dbo.cliente.cod_cliente", conexion);
            SqlDataAdapter das = new SqlDataAdapter(cmd);
            DataTable dta = new DataTable();
            das.Fill(dta);
            

            foreach (DataRow dr in dta.Rows)
            {
                //Creamos un objeto de la clase persona
                PersonalUAU.Clases.Persona objPersona = new PersonalUAU.Clases.Persona();
                objPersona.id = Convert.ToInt32(dr["cod_cliente"].ToString());
                objPersona.huella = dr["Huella"].ToString();
                objPersona.Nombre = dr["nombre"].ToString();
                listPerson.Add(objPersona);
            }
            //verificamos si existe la persona (cliente)
            objMethods.StartIdentify(objReader, listPerson);
            conexion.Close();
        }

        private void Listar(string nom)
        {
            string ConString = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM GYM.Vistaasistencias WHERE nombre like '%"+nom+"%'";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Vistaasistencias");
                sda.Fill(dt);
                dg_checadas.ItemsSource = dt.DefaultView;
            }
        }

        private void txt_buscar_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Listar(txt_buscar.Text);
        }
    }
}
