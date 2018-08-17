using Negocios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Datos;
using Dragablz;
using PersonalUAU.CapturaHuella;
using DPUruNet;
using System.Data.SqlClient;

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for nuevo_cliente.xaml
    /// </summary>
    public partial class nuevo_cliente
    {
        PersonalUAU.DigitalPersona objMethods;
        Reader objReader;
        string xml;
        List<PersonalUAU.Clases.Persona> listPerson;
        string cs = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;

        int codigo;

        public string Response { get; set; }

        public nuevo_cliente()
        {
            InitializeComponent();

        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                //obtenemos los valores de los texbox y los mandamos a la entidad cliente
                Entidades.clientes cliente = new Entidades.clientes
                {
                    CLIENTE_NOMBRE = txt_nom_new.Text,
                    CLIENTE_CIUDAD = "Culiacan",
                    CLIENTE_DIRECCION = txt_dir_new.Text,
                    CLIENTE_TELEFONO = txt_tel_new.Text,
                    CLIENTE_SEXO = ((ComboBoxItem)txt_sex_new.SelectedItem).Tag.ToString(),
                    CLIENTE_CORREO = txt_correo_new.Text,
                    CLIENTE_FECHA_NAC = txt_nac_new.DisplayDate,
                    CLIENTE_ALTURA = Convert.ToDecimal(txt_altura_new.Text),
                    CLIENTE_PESO = Convert.ToDecimal(txt_peso_new.Text),
                    CLIENTE_CUELLO = Convert.ToDecimal(txt_cuello_new.Text),
                    CLIENTE_BRAZO = Convert.ToDecimal(txt_brazo_new.Text),
                    CLIENTE_TORAX = Convert.ToDecimal(txt_torax_new.Text),
                    CLIENTE_CINTURA = Convert.ToDecimal(txt_cintura_new.Text),
                    CLIENTE_CADERA = Convert.ToDecimal(txt_cadera_new.Text),
                    CLIENTE_PIERNA = Convert.ToDecimal(txt_pierna_new.Text),
                    CLIENTE_PANTORRILLA = Convert.ToDecimal(txt_pantorrilla_new.Text),
                    
                };
                //registrar en la base de datos
                codigo = new da_clientes().Crear_cliente(cliente);
                //MessageBox.Show("Cliente Registrado Correctamente");
                //CAMBIAR DE PESTAÑA
                tab_huella.IsSelected = true;
                tab_huella.Focus();
               

            }
            catch (Exception err)
            {
                MessageBox.Show("Error, " + err.Message);
            }
            //this.Close();
            Response = "ok";

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

        private void txtSalida_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_asignar_huella_Click(object sender, RoutedEventArgs e)
        {

            //iniciamos el proceso de captura de la huella

            //AppData data = new AppData(Convert.ToInt32(codigo));
            objMethods = new PersonalUAU.DigitalPersona();

            //For one device detected by the computer
            objReader = objMethods.GetDevice();
            listPerson = new List<PersonalUAU.Clases.Persona>();
            
            objMethods.ShowWindowEnrollment(objReader);
            xml = objMethods.GetFingerprint_XML();
            //MessageBox.Show(xml);
            
            //registrar en la base de datos
            try
            {
                //insertamos en la base de datos
                SqlConnection conexion = new SqlConnection(cs);
                conexion.Open();
                string comando = "IF EXISTS (SELECT 1 FROM GYM.Huellas WHERE cod_cliente=" + codigo + ")" +
                                " BEGIN " +
                                " UPDATE GYM.Huellas SET Huella = '" + xml + "' WHERE cod_cliente = '" + codigo + "'" +
                                " END " +
                                " ELSE " +
                                " BEGIN " +
                                " INSERT INTO GYM.Huellas VALUES (" + codigo + ",0,'" + xml + "')" +
                                " END ";
                SqlCommand query = new SqlCommand(comando, conexion);
                query.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
             
        }

    }
}
