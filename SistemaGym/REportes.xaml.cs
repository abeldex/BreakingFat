using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for REportes.xaml
    /// </summary>
    public partial class REportes : Window
    {
        public REportes()
        {
            InitializeComponent();
            dp_fecha_diaria.SelectedDate = DateTime.Now;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GenerarReporteDiario();
        }

        private void GenerarReporteDiario()
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

            var fileName = "RD_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".pdf";

            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.UNDERLINE, BaseColor.BLACK);
            var h1Font = FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD);
            var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.NORMAL, BaseColor.DARK_GRAY);

            try
            {
                var pdfWriter = PdfWriter.GetInstance(doc, new FileStream(strFilePath + fileName, FileMode.Create));
                pdfWriter.PageEvent = new ITextEvents();
                doc.Open();

                var tblContainer = new PdfPTable(8) { TotalWidth = 520f, LockedWidth = true };
                float[] widths = { 60f, 60f, 60f, 60f, 60f, 60f, 60f, 60f };
                tblContainer.SetWidths(widths);
                var heading = new Phrase("Reporte de Asistencias Diario.\n\n", h1Font);
                var titleCOD = new Phrase("COD", titleFont);
                var titleNOM = new Phrase("NOMBRE", titleFont);
                var titleTIPO = new Phrase("TIPO", titleFont);
                var titleFI = new Phrase("FI", titleFont);
                var titleFF = new Phrase("FF", titleFont);
                var titleCOS = new Phrase("COSTO", titleFont);
                var titleEST = new Phrase("ESTADO", titleFont);
                var titleCH = new Phrase("CHECADA", titleFont);
                var cellTicketName = new PdfPCell(heading) { Colspan = 8, Border = 0 };
                var cellTitleCOD = new PdfPCell(titleCOD);
                var cellTitleNOM = new PdfPCell(titleNOM);
                var cellTitleTIPO = new PdfPCell(titleTIPO);
                var cellTitleFI = new PdfPCell(titleFI);
                var cellTitleFF = new PdfPCell(titleFF);
                var cellTitleCOS = new PdfPCell(titleCOS);
                var cellTitleEST = new PdfPCell(titleEST);
                var cellTitleCH = new PdfPCell(titleCH);

                cellTitleCOD.Border = 0;
                cellTitleNOM.Border = 0;
                cellTitleTIPO.Border = 0;
                cellTitleFI.Border = 0;
                cellTitleFF.Border = 0;
                cellTitleCOS.Border = 0;
                cellTitleEST.Border = 0;
                cellTitleCH.Border = 0;

                tblContainer.AddCell(cellTicketName);
                tblContainer.AddCell(new PdfPCell(new Phrase("")) { Colspan = 8, Border = 0 });

                tblContainer.AddCell(cellTitleCOD);
                tblContainer.AddCell(cellTitleNOM);
                tblContainer.AddCell(cellTitleTIPO);
                tblContainer.AddCell(cellTitleFI);
                tblContainer.AddCell(cellTitleFF);
                tblContainer.AddCell(cellTitleCOS);
                tblContainer.AddCell(cellTitleEST);
                tblContainer.AddCell(cellTitleCH);
                doc.Add(tblContainer);

                //agregamos los datos de la tabla de clientes
                //agregamos los detalles
                //seleccionamos de la base de datos
                //insertamos en la base de datos
                string cs = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;
                SqlConnection conexion = new SqlConnection(cs);
                DataTable dt = new DataTable();
                conexion.Open();
                SqlCommand query = new SqlCommand("select cliente.cod_cliente, nombre, tipo_membresia, Convert (varchar(10), fecha_inicial, 120) as 'fecha_inicial', Convert(varchar(10), fecha_final, 120) as 'fecha_final', costo, CASE WHEN fecha_inicial = GETDATE() THEN 'Vencida' else 'Activo' END AS 'Estado', LTRIM(RIGHT(CONVERT(VARCHAR(20),checada, 100), 7)) as 'checada' from cliente inner join GYM.membresia on cliente.cod_cliente = GYM.membresia.cod_cliente inner join GYM.asistencias on GYM.asistencias.cod_cliente = GYM.membresia.cod_cliente where LEFT(convert(varchar, checada, 120), 10) like '%" + Convert.ToDateTime(dp_fecha_diaria.SelectedDate).ToString("yyyy-MM-dd") +"'", conexion);
                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(dt);

                var tblResult = new PdfPTable(8) { TotalWidth = 520f, LockedWidth = true };
                tblResult.SetWidths(widths);

                foreach (DataRow row in dt.Rows)
                {
                    var cod = new Phrase(row["cod_cliente"].ToString(), bodyFont);
                    var nom = new Phrase(row["nombre"].ToString(), bodyFont);
                    var tipo = new Phrase(row["tipo_membresia"].ToString(), bodyFont);
                    var fi = new Phrase(row["fecha_inicial"].ToString(), bodyFont);
                    var ff = new Phrase(row["fecha_final"].ToString(), bodyFont);
                    var cos = new Phrase(row["costo"].ToString(), bodyFont);
                    var est = new Phrase(row["Estado"].ToString(), bodyFont);
                    var ch = new Phrase(row["checada"].ToString(), bodyFont);

                    var cellCOD = new PdfPCell(cod);
                    var cellNOM = new PdfPCell(nom);
                    var cellTIP = new PdfPCell(tipo);
                    var cellFI = new PdfPCell(fi);
                    var cellFF = new PdfPCell(ff);
                    var cellCOS = new PdfPCell(cos);
                    var cellEST = new PdfPCell(est);
                    var cellCH = new PdfPCell(ch);

                    cellCOD.Border = 0;
                    cellNOM.Border = 0;
                    cellTIP.Border = 0;
                    cellFI.Border = 0;
                    cellFF.Border = 0;
                    cellCOS.Border = 0;
                    cellEST.Border = 0;
                    cellCH.Border = 0;

                    tblResult.AddCell(cellCOD);
                    tblResult.AddCell(cellNOM);
                    tblResult.AddCell(cellTIP);
                    tblResult.AddCell(cellFI);
                    tblResult.AddCell(cellFF);
                    tblResult.AddCell(cellCOS);
                    tblResult.AddCell(cellEST);
                    tblResult.AddCell(cellCH);
                }
                doc.Add(tblResult);
                doc.Close();
                byte[] contents = System.IO.File.ReadAllBytes(strFilePath + fileName);
                Uri uri = new Uri(strFilePath + fileName);
                wb_diario.Source = uri;
                conexion.Close();

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
