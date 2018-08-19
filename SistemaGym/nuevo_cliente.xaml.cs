using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using Datos;
using DPUruNet;

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for nuevo_cliente.xaml
    /// </summary>
    public partial class nuevo_cliente
    {
        //objetos para interactuar con el lector de huellas
        PersonalUAU.DigitalPersona objMethods;
        Reader objReader;
        string xml;
        List<PersonalUAU.Clases.Persona> listPerson;
        //codig que obtendremos el nuevo cliente registrado
        int codigo;

        public string Response { get; set; }

        public nuevo_cliente()
        {
            InitializeComponent();
            //inicializar los objetos
            dp_fecha_inicial.SelectedDate = DateTime.Now;
            dp_fecha_final.SelectedDate = DateTime.Now.AddMonths(1);
            lbl_total_pagar.Text = "$" + ConfigurationManager.AppSettings.Get("Mensual");

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
                codigo = new Da_clientes().Crear_cliente(cliente);
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
                bool respuesta = new Da_clientes().Huella_cliente(codigo, xml);
                //si se registro correctamente la huella pasamos a la pestaña de membresias
                if (respuesta)
                {
                    //realizamos el cambio de pestaña
                    tab_membresia.IsSelected = true;
                    tab_membresia.Focus();
                }
                    
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }   
        }

        private void rb_mensual_Click(object sender, RoutedEventArgs e)
        {
            //asignamos el precio a la etiqueta del precio y agregamos 1 mes al control fecha final
            lbl_total_pagar.Text = "$"+ ConfigurationManager.AppSettings.Get("Mensual");
            dp_fecha_final.SelectedDate = dp_fecha_inicial.SelectedDate.Value.AddMonths(1);
           
        }

        private void rb_semanal_Click(object sender, RoutedEventArgs e)
        {
            //asignamos el precio a la etiqueta del precio y agregamos 7 dias al control fecha final
            lbl_total_pagar.Text = "$" + ConfigurationManager.AppSettings.Get("Semanal");
            dp_fecha_final.SelectedDate = dp_fecha_inicial.SelectedDate.Value.AddDays(7);
        }

        private void rb_diario_Click(object sender, RoutedEventArgs e)
        {
            //asignamos el precio a la etiqueta del precio y agregamos 1 dia al control fecha final
            lbl_total_pagar.Text = "$" + ConfigurationManager.AppSettings.Get("Diario");
            dp_fecha_final.SelectedDate = dp_fecha_inicial.SelectedDate.Value.AddDays(1);
        }

        private void RegistrarMembresia()
        {
            //Obtenemos los valores de los controles y los guardamos en la entidad membresias
            Entidades.Membresias membresias = new Entidades.Membresias();
            membresias.cod_cliente = codigo;
            membresias.costo = float.Parse(lbl_total_pagar.Text.Substring(1));
            membresias.descuento = float.Parse(txt_descuento.Text);
            membresias.fecha_inicial = dp_fecha_inicial.SelectedDate.Value;
            membresias.fecha_final = dp_fecha_final.SelectedDate.Value;

            ventas.Cobrar cobrar = new ventas.Cobrar(lbl_total_pagar.Text.Substring(1), "1");
            cobrar.ShowDialog();
        }

        private void btn_cobrar_Click(object sender, RoutedEventArgs e)
        {
            RegistrarMembresia();
        }
    }
}
