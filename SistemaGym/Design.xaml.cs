using Microsoft.Win32;
using System;
using System.Configuration;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for Design.xaml
    /// </summary>
    public partial class Design : Window
    {
        MaterialDesignThemes.Wpf.PaletteHelper materialPaletteHelper = new MaterialDesignThemes.Wpf.PaletteHelper();

        public Design()
        {
            InitializeComponent();
            cargar_configuraciones();
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
                wallpaper.Source = new BitmapImage(uriFondo);
                wallpaper.Opacity = 0.3;
            }
            catch 
            {
                //MessageBox.Show("EL Fondo de la aplicación no se ha configurado, por favor ve al menu de configuracion.", "Fondo no configurado");
            }
  
        }

        private void cargar_configuraciones()
        {
            //precios
            txt_diario.Text = ConfigurationManager.AppSettings.Get("Diario");
            txt_mensual.Text = ConfigurationManager.AppSettings.Get("Mensual");
            txt_semanal.Text = ConfigurationManager.AppSettings.Get("Semanal");

            //informacion
            txt_nombre_gym.Text = ConfigurationManager.AppSettings.Get("nombre");
            txt_telefono.Text = ConfigurationManager.AppSettings.Get("telefono");
            txt_email.Text = ConfigurationManager.AppSettings.Get("email");
            txt_dir.Text = ConfigurationManager.AppSettings.Get("direccion");
        }

        private void LightThemeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.SetLightDark(false);
            DarkThemeCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("tema", "Light");
        }

        private void DarkThemeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.SetLightDark(true);
            LightThemeCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("tema", "Dark");
        }

        private void GreenCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplacePrimaryColor("Green");
            RedCheckBox.IsChecked = false;
            CyanCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("color", "Green");
        }

        private void RedCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplacePrimaryColor("Red");
            GreenCheckBox.IsChecked = false;
            CyanCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("color", "Red");
        }

        private void CyanCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplacePrimaryColor("Cyan");
            GreenCheckBox.IsChecked = false;
            RedCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("color", "Cyan");
        }

        private void PinkCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplacePrimaryColor("Pink");
            GreenCheckBox.IsChecked = false;
            RedCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("color", "Pink");
        }

        private void GreenAccentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplaceAccentColor("Green");
            RedAccentCheckBox.IsChecked = false;
            CyanAccentCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("colorsec", "Green");
        }

        private void RedAccentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplaceAccentColor("Red");
            GreenAccentCheckBox.IsChecked = false;
            CyanAccentCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("colorsec", "Red");
        }

        private void CyanAccentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplaceAccentColor("Cyan");
            GreenAccentCheckBox.IsChecked = false;
            RedAccentCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("colorsec", "Cyan");
        }

        private void PinkAccentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplaceAccentColor("Pink");
            GreenAccentCheckBox.IsChecked = false;
            RedAccentCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("colorsec", "Pink");
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            /*LightThemeCheckBox.IsChecked = true;
            RedAccentCheckBox.IsChecked = true;
            RedCheckBox.IsChecked = true;*/
        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Insert an image ";
            openFD.InitialDirectory = "c:";
            openFD.FileName = "";
            openFD.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            openFD.Multiselect = false;
            if (openFD.ShowDialog() != true)
                return;

            //mostramos la imagen
            Uri uriSource = new Uri(openFD.FileName);
            BitmapImage img = new BitmapImage(uriSource);
            logo.Source = img;

            try
            {
                //copiamos la imagen al directorio
                string new_dir = @"" + Directory.GetCurrentDirectory() + "\\imagenes\\";
                string extension = System.IO.Path.GetExtension(openFD.FileName);
                string renamed_name = openFD.SafeFileName;
                string fName = System.IO.Path.Combine(new_dir, renamed_name);
                if (File.Exists(fName))
                    File.Delete(fName);
                System.IO.File.Copy(openFD.FileName, fName);

                AddOrUpdateAppSettings("logo", fName);
                
            }
            catch
            {
                //MessageBox.Show("El logo ya existe en la carpeta de imagenes\n Tip: renombra la imagen");
            }   
        }

        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error al escribir la configuracion");
            }
        }

        private void wallpaper_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Seleccione un fondo ";
            openFD.InitialDirectory = "c:";
            openFD.FileName = "";
            openFD.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            openFD.Multiselect = false;
            if (openFD.ShowDialog() != true)
                return;

            //mostramos la imagen
            Uri uriSource = new Uri(openFD.FileName);
            BitmapImage img = new BitmapImage(uriSource);
            wallpaper.Source = img;
            try
            {
                //copiamos la imagen al directorio
                string new_dir = @"" + Directory.GetCurrentDirectory() + "\\imagenes\\";
                string extension = System.IO.Path.GetExtension(openFD.FileName);
                string renamed_name = openFD.SafeFileName;
                string fName = System.IO.Path.Combine(new_dir, renamed_name);
                if (File.Exists(fName))
                    File.Delete(fName);
                System.IO.File.Copy(openFD.FileName, fName);
                AddOrUpdateAppSettings("fondo", fName);
            }
            catch
            {
               // MessageBox.Show("El fondo seleccionado ya existe en la carpeta de imagenes\n Tip: renombra la imagen");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //actualizamos los datos del archivo de configuracion
            AddOrUpdateAppSettings("nombre", txt_nombre_gym.Text);
            AddOrUpdateAppSettings("telefono", txt_telefono.Text);
            AddOrUpdateAppSettings("email", txt_email.Text);
            AddOrUpdateAppSettings("direccion", txt_dir.Text);
            cargar_configuraciones();
        }

        private void btn_precios_Click(object sender, RoutedEventArgs e)
        {
            //actualizamos los datos del archivo de configuracion
            AddOrUpdateAppSettings("Diario", txt_diario.Text);
            AddOrUpdateAppSettings("Semanal", txt_semanal.Text);
            AddOrUpdateAppSettings("Mensual", txt_mensual.Text);
            cargar_configuraciones();
        }

        private void TealCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplacePrimaryColor("Teal");
            RedCheckBox.IsChecked = false;
            CyanCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("color", "Teal");
        }

        private void WhiteAccentCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            materialPaletteHelper.ReplaceAccentColor("Teal");
            GreenAccentCheckBox.IsChecked = false;
            RedAccentCheckBox.IsChecked = false;
            AddOrUpdateAppSettings("colorsec", "Teal");
        }
    }
}
