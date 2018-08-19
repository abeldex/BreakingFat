using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for BuscarCliente.xaml
    /// </summary>
    public partial class BuscarCliente : Window
    {
        public BuscarCliente()
        {
            InitializeComponent();
            Listar();
        }

        public void Listar()
        {
            try
            {
               // lb_clientes.ItemsSource = new Nclientes().ListarClientes(txt_buscar.Text);
                lb_clientes.DisplayMemberPath = "NOMBRE";
                lb_clientes.SelectedValuePath = "COD";
                //lb_clientes.
                // define Display and Value members
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txt_buscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Listar();
        }

        private void lb_clientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lb_clientes.SelectedIndex != -1)
            {
               /* Datos.VistaClientes vc = new Datos.VistaClientes();
                //vc = lb_clientes.SelectedItem;
                int index = lb_clientes.SelectedIndex; // get the index of selected item 
                ListBoxItem listitem = (ListBoxItem)(lb_clientes.ItemContainerGenerator.ContainerFromIndex(index));
                vc = (Datos.VistaClientes)listitem.Content;
                //MessageBox.Show(vc.COD.ToString());
                Membresias mm = new Membresias(vc.COD);
                mm.Show();
                Close();*/
            }
            else
            {
                MessageBox.Show("Seleccione un cliente primero");
            }
            
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
      
    }
}
