using ControlVentas.modelo.dao;
using ControlVentas.modelo.poco;
using System.Windows;


namespace ControlVentas.vista
{
    /// <summary>
    /// Lógica de interacción para CrearCategoria.xaml
    /// </summary>
    public partial class CrearCategoria : Window
    {
        private AbstractDao daoCategoria;

        public CrearCategoria()
        {
            InitializeComponent();
            daoCategoria = new CategoriaDao();
        }

        private void botonGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (!textBoxNombre.Text.Equals(""))
            {
                Categoria categoria = new Categoria();
                categoria.Nombre = textBoxNombre.Text;

                if (daoCategoria.crear(categoria) == 1) 
                {
                    MainWindow.ejecutarWorkerCategoria();
                    MessageBox.Show("¡La nueva categoría fue creada en el sistema!","Mensaje del sistema",MessageBoxButton.OK, MessageBoxImage.Information);
                    textBoxNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("No se ha podido completar la operación!", "Mensaje del sistema", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else 
            {
                MessageBox.Show("Debes ingresar un nombre para la categoría","Mensaje del sistema",MessageBoxButton.OK,MessageBoxImage.Information);
                textBoxNombre.Focus();
            }
        }
    }
}
