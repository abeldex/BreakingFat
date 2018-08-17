using System;
using System.Configuration;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        MaterialDesignThemes.Wpf.PaletteHelper materialPaletteHelper = new MaterialDesignThemes.Wpf.PaletteHelper();

        public MainWindow()
        {
            
            InitializeComponent();
            try
            {
                string titulo = ConfigurationManager.AppSettings.Get("nombre");
                string color = ConfigurationManager.AppSettings.Get("color");
                string colorac = ConfigurationManager.AppSettings.Get("colorsec");
                string tema = ConfigurationManager.AppSettings.Get("tema");
                materialPaletteHelper.ReplacePrimaryColor(color);
                materialPaletteHelper.ReplaceAccentColor(colorac);
                if (tema == "Light")
                    materialPaletteHelper.SetLightDark(false);
                else
                    materialPaletteHelper.SetLightDark(true);

                txt_titulo.Text = titulo;
            }
            catch
            {

            }
            
            changeIdentity();
            
        }

        public void changeIdentity()
        {
            try
            {
                Uri uriSource = new Uri(ConfigurationManager.AppSettings.Get("logo"));
                BitmapImage img = new BitmapImage(uriSource);
                logo.Source = img;
            }
            catch
            {
                //MessageBox.Show("EL logotipo de la aplicación no se ha configurado, por favor ve al menu de configuracion.", "Logotipo no configurado");

            }
            try
            {
                Uri uriFondo = new Uri(ConfigurationManager.AppSettings.Get("fondo"));
                wallpaper.ImageSource = new BitmapImage(uriFondo);
                wallpaper.Opacity = 0.3;
            }
            catch
            {
                //MessageBox.Show("EL Fondo de la aplicación no se ha configurado, por favor ve al menu de configuracion.", "Fondo no configurado");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ListBoxItem_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            clientes c = new clientes();
            c.Show();
        }

        private void ListBoxItem_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            VerChecador vch = new VerChecador();
            vch.Show();
        }

        private void ListBoxItem_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            AdministracionMembresias am = new AdministracionMembresias();
            am.Show();
        }

        private void ListBoxItem_MouseLeftButtonUp_3(object sender, MouseButtonEventArgs e)
        {
            ControlVentas.MainWindow ventas = new ControlVentas.MainWindow();
            ventas.Show();
        }

        private void ListBoxItem_MouseLeftButtonUp_4(object sender, MouseButtonEventArgs e)
        {
            //PaletteSelector
            Design d = new Design();
            d.Show();
        }

    }
}
