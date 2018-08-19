using System;
using System.Configuration;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static System.Windows.Forms.Form;

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for Membresias.xaml
    /// </summary>
    public partial class Membresias : Window
    {
        public int codigo; //variable que recoge el id de cliente (ya sea nuevo o del frmCliente)
        public bool Nuevo; //variable para sabe si es un registro nuevo o edicion
        public int cantidad;
        public double diario = double.Parse(ConfigurationManager.AppSettings.Get("Diario"));
        public double mensual = double.Parse(ConfigurationManager.AppSettings.Get("Mensual"));
        public double semanal = double.Parse(ConfigurationManager.AppSettings.Get("Semanal"));

        public Membresias(int cod_cliente)
        {
            InitializeComponent();
            date_inicio.SelectedDate = DateTime.Now.Date;
            date_fin.SelectedDate = DateTime.Now.Date;
            date_fin.IsEnabled = false;
            date_inicio.IsEnabled = false;
            txt_descuento.Text = "0";
            codigo = cod_cliente;
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void seleccionar_dias()
        {
            InputDialog inputDialog = new InputDialog("Ingrese la cantidad:", "1");
            if (inputDialog.ShowDialog() == true)
                cantidad = int.Parse(inputDialog.Answer);

            calcular_dias(cantidad);
        }

        private void calcular_dias(int cantidad)
        {

            if (Convert.ToBoolean(rb_diario.IsChecked))
            {
                //si se marco diario
                date_inicio.IsEnabled = false;
                date_fin.IsEnabled = false;
                date_fin.SelectedDate = date_inicio.SelectedDate;
                txt_subtotal.Text = diario.ToString();
            }
            else if (Convert.ToBoolean(rb_semana.IsChecked))
            {
                //si se marco semana
                date_fin.SelectedDate = date_inicio.SelectedDate;
                txt_subtotal.Text = (cantidad * semanal).ToString();
                int dias = cantidad * 7;
                int contador = 1;
                while (contador != dias)
                {
                    date_fin.SelectedDate = date_fin.SelectedDate.Value.AddDays(1);
                    contador++;
                    /*if (date_fin.DisplayDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                       
                    }
                    else
                    {
                        date_fin.SelectedDate = date_fin.SelectedDate.Value.AddDays(1);
                    }*/
                }

                //ver si de casualidad callo en domingo
                if (date_fin.DisplayDate.DayOfWeek == DayOfWeek.Sunday)
                    date_fin.SelectedDate = date_fin.DisplayDate.Date.AddDays(1);

                date_inicio.IsEnabled = true;
                date_fin.IsEnabled = false;
            }
            else
            {
                //si se eligio en mes
                date_fin.SelectedDate = date_inicio.SelectedDate;
                txt_subtotal.Text = (cantidad * mensual).ToString();
                date_fin.SelectedDate = date_inicio.SelectedDate.Value.AddMonths(cantidad);
                date_inicio.IsEnabled = true;
                date_fin.IsEnabled = false;
            }

        }

        private void rb_semana_Click(object sender, RoutedEventArgs e)
        {
            seleccionar_dias();
        }

        private void rb_mes_Click(object sender, RoutedEventArgs e)
        {
            seleccionar_dias();
        }

        private void txt_subtotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_total.Text = txt_subtotal.Text;
        }

        private void txt_total_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_descuento_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_subtotal.Text == "" || (txt_subtotal.Text == String.Empty))
                txt_subtotal.Text = "0";
            else
                txt_total.Text = (double.Parse(txt_subtotal.Text) - double.Parse(txt_descuento.Text)).ToString("0.0");
        }

        private void rb_diario_Click(object sender, RoutedEventArgs e)
        {
            calcular_dias(1);
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            string servicio = "";
            //obtener el tipo de servicio seleccionado
            if (Convert.ToBoolean(rb_gym.IsChecked))
                servicio = "Gimansio";
            else if (Convert.ToBoolean(rb_zumba.IsChecked))
                servicio = "Zumba";
            else
                servicio = "Crossfit";
            //guardamos en la base de datos
            try
            {
                /*entidad_membresia em = new entidad_membresia();
                em.COD_CLIENTE = codigo;
                em.TIPO_MEMBRESIA = servicio;
                em.FECHA_INICIAL = date_inicio.SelectedDate.Value;
                em.FECHA_FINAL = date_fin.SelectedDate.Value;
                em.DESCUENTO = float.Parse(txt_descuento.Text);
                em.COSTO = float.Parse(txt_total.Text);
                MessageBox.Show("Se añadio la membresia a el cliente correctamente");
                new Nmembresia().Insertar(em);*/
                Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("úps" + ee.Message);
            }
            AdministracionMembresias amm = new AdministracionMembresias();
            amm.Listar();

        }

        private void date_inicio_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                calcular_dias(cantidad);
            }
            catch (Exception err)
            {
                MessageBox.Show("seleccione la cantidad de semanas o meses primero", err.Message);
            }
        }
    }
}
