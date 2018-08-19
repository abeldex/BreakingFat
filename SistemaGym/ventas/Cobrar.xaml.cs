using LibPrintTicket;
using System;
using System.Collections.Generic;
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

namespace SistemaGym.ventas
{
    /// <summary>
    /// Interaction logic for Cobrar.xaml
    /// </summary>
    public partial class Cobrar
    {
        public Cobrar()
        {
            InitializeComponent();
            txt_pago.Focus();
        }

        public Cobrar(string cantidad_cobrar, string cantidad_art)
        {
            InitializeComponent();
            txt_pago.Focus();
            txt_cantidad.Text = "$" + cantidad_cobrar;
            txt_cant_art.Text = cantidad_art;
        }

        private void txt_pago_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                float cambio = (float.Parse(txt_pago.Text) - float.Parse(txt_cantidad.Text.Substring(1)));
                if(cambio >= 0)
                    txt_cambio.Text = "$" +cambio.ToString();
                else
                    txt_cambio.Text = "Cantidad inválida";
            }
            catch 
            {
                
            }
            
        }

        public void generarTicket()
        {
            Ticket ticket = new Ticket();

            ticket.AddHeaderLine("ChafiTienda");
            ticket.AddHeaderLine("EXPEDIDO EN:");
            ticket.AddHeaderLine("CALLE CONOCIDA");
            ticket.AddHeaderLine("PUEBLA, PUEBLA");
            ticket.AddHeaderLine("RFC: CSI-020226-MV4");

            ticket.AddSubHeaderLine("Ticket # 1");
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            ticket.AddItem("Cantidad", "Nombre producto", "Total");

            ticket.AddTotal("SUBTOTAL", "12.00");
            ticket.AddTotal("IVA", "0");
            ticket.AddTotal("TOTAL", "24");
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", "0");
            ticket.AddTotal("CAMBIO", "0");
            ticket.AddTotal("", "");

            ticket.AddFooterLine("VUELVA PRONTO");

            ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
        }
    }
}
