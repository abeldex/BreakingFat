using Datos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using Negocios;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace SistemaGym
{
    /// <summary>
    /// Interaction logic for AdministracionMembresias.xaml
    /// </summary>
    public partial class AdministracionMembresias : Window
    {
        public AdministracionMembresias()
        {
            InitializeComponent();
            Listar();
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Listar()
        {
            try
            {
                dg_membresias.ItemsSource = new Nmembresia().ListarMembresias();
                dg_membresias.Items.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_nueva_Click(object sender, RoutedEventArgs e)
        {

            BuscarCliente bc = new BuscarCliente();
            bc.Show();
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            //obtenemos el usuario desde el datagrid por medio de la fila seleccionada
            object Cliente = ((Button)sender).CommandParameter;
            //mandamos un mensaje para preguntar si deseamos eliminar
            MessageBoxResult result = MessageBox.Show("Realmente desea eliminar el registro "+ Cliente.ToString()+" ?", "Piense", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    new Nmembresia().Eliminar(Convert.ToInt32(Cliente));
                    Listar();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
                
        }

        private void btn_actualizar_Click(object sender, RoutedEventArgs e)
        {
            Listar();
        }

        private void btn_imprimir_Click(object sender, RoutedEventArgs e)
        {
            GenerarReporte();
        }

        public void GenerarReporte()
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

            var fileName = "Membresias_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".pdf";

            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.UNDERLINE, BaseColor.BLACK);
            var h1Font = FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD);
            var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.NORMAL, BaseColor.DARK_GRAY);

            try
            {
                var pdfWriter = PdfWriter.GetInstance(doc, new FileStream(strFilePath + fileName, FileMode.Create));
                pdfWriter.PageEvent = new ITextEvents();
                doc.Open();

                var tblContainer = new PdfPTable(7) { TotalWidth = 520f, LockedWidth = true };
                float[] widths = { 30f, 120f, 50f, 74f, 74f, 74f, 74f };
                tblContainer.SetWidths(widths);
                var heading = new Phrase("Reporte de Membresias.\n\n", h1Font);
                var titleCOD = new Phrase("COD", titleFont);
                var titleCLI = new Phrase("CLIENTE", titleFont);
                var titleTI = new Phrase("TIPO", titleFont);
                var titleI = new Phrase("INICIO", titleFont);
                var titleF = new Phrase("FIN", titleFont);
                var titleCO = new Phrase("COSTO", titleFont);
                var titleDE = new Phrase("DESCUENTO", titleFont);

                var cellTicketName = new PdfPCell(heading) { Colspan = 4, Border = 0 };
                var cellTitleCOD = new PdfPCell(titleCOD);
                var cellTitleCLI = new PdfPCell(titleCLI);
                var cellTitleTI = new PdfPCell(titleTI);
                var cellTitleI = new PdfPCell(titleI);
                var cellTitlF = new PdfPCell(titleF);
                var cellTitleCO = new PdfPCell(titleCO);
                var cellTitleDE = new PdfPCell(titleDE);

                cellTitleCOD.Border = 0;
                cellTitleCLI.Border = 0;
                cellTitleTI.Border = 0;
                cellTitleI.Border = 0;
                cellTitlF.Border = 0;
                cellTitleCO.Border = 0;
                cellTitleDE.Border = 0;

                tblContainer.AddCell(cellTicketName);
                tblContainer.AddCell(new PdfPCell(new Phrase("")) { Colspan = 7, Border = 0 });

                tblContainer.AddCell(cellTitleCOD);
                tblContainer.AddCell(cellTitleCLI);
                tblContainer.AddCell(cellTitleTI);
                tblContainer.AddCell(cellTitleI);
                tblContainer.AddCell(cellTitlF);
                tblContainer.AddCell(cellTitleCO);
                tblContainer.AddCell(cellTitleDE);

                doc.Add(tblContainer);

                //agregamos los datos de la tabla de clientes
                //agregamos los detalles
                List<membresias> memb;
                memb = new Nmembresia().ListarMembresias();
                var tblResult = new PdfPTable(7) { TotalWidth = 520f, LockedWidth = true };
                tblResult.SetWidths(widths);

                foreach (membresias m in memb)
                {

                    var cod = new Phrase(m.id_membresia.ToString(), bodyFont);
                    var cliente = new Phrase(m.nombre, bodyFont);
                    var tipo = new Phrase(m.tipo_membresia, bodyFont);
                    var inicio = new Phrase(m.fecha_inicial.Value.ToShortDateString(), bodyFont);
                    var fin = new Phrase(m.fecha_final.Value.ToShortDateString(), bodyFont);
                    var costo = new Phrase("$"+m.costo.ToString(), bodyFont);
                    var desc = new Phrase("$"+m.descuento.ToString(), bodyFont);


                    var cellCOD = new PdfPCell(cod);
                    var cellNOM = new PdfPCell(cliente);
                    var cellTI = new PdfPCell(tipo);
                    var cellI = new PdfPCell(inicio);
                    var cellF = new PdfPCell(fin);
                    var cellCOS = new PdfPCell(costo);
                    var cellDES = new PdfPCell(desc);

                    cellCOD.Border = 0;
                    cellNOM.Border = 0;
                    cellTI.Border = 0;
                    cellI.Border = 0;
                    cellF.Border = 0;
                    cellCOS.Border = 0;
                    cellDES.Border = 0;

                    tblResult.AddCell(cellCOD);
                    tblResult.AddCell(cellNOM);
                    tblResult.AddCell(cellTI);
                    tblResult.AddCell(cellI);
                    tblResult.AddCell(cellF);
                    tblResult.AddCell(cellCOS);
                    tblResult.AddCell(cellDES);


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
    }
}
