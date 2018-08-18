using System;
using System.Collections;
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
using Datos;

namespace SistemaGym.Vclientes
{
    /// <summary>
    /// Interaction logic for Perfil.xaml
    /// </summary>
    public partial class Perfil
    {
        //int cod_cliente = 4;
        da_clientes dacli = new da_clientes();
        Entidades.clientes cli = new Entidades.clientes();

        public Perfil(object codigo)
        {
            InitializeComponent();
            
            cli = (Entidades.clientes)dacli.obtener_datos(Convert.ToInt32(codigo));
            //cargamos los datos personales 
            lbl_titulo.Text = cli.CLIENTE_NOMBRE;
            lbl_cod.Text = cli.CLIENTE_COD.ToString();
            lbl_nombre.Text = cli.CLIENTE_NOMBRE;
            lbl_direccion.Text = cli.CLIENTE_DIRECCION;
            lbl_telefono.Text = cli.CLIENTE_TELEFONO;
            lbl_sexo.Text = cli.CLIENTE_SEXO;
            lbl_correo.Text = cli.CLIENTE_CORREO;
            lbl_fecha.Text = cli.CLIENTE_FECHA_NAC.ToShortDateString();
            
            lbl_altura.Text = cli.CLIENTE_ALTURA.ToString();
            lbl_peso.Text = cli.CLIENTE_PESO.ToString();
            lbl_cuello.Text = cli.CLIENTE_CUELLO.ToString();
            lbl_torax.Text = cli.CLIENTE_TORAX.ToString();
            lbl_brazo.Text = cli.CLIENTE_BRAZO.ToString();
            lbl_cintura.Text = cli.CLIENTE_CINTURA.ToString();
            lbl_cadera.Text = cli.CLIENTE_CADERA.ToString();
            lbl_pierna.Text = cli.CLIENTE_PIERNA.ToString();
            lbl_pantorrilla.Text = cli.CLIENTE_PANTORRILLA.ToString();
            //IMC = Peso(kg) / (Estatura(m)  x Estatura(m) )
            decimal IMC = cli.CLIENTE_PESO / (cli.CLIENTE_ALTURA * cli.CLIENTE_ALTURA);
            lbl_IMC.Text = IMC.ToString("F");
            //lbl_Grasa.Text = CalcularGrasaCorporal(cli).ToString("F");
        }

       /* private decimal CalcularGrasaCorporal(Entidades.clientes c)
        {
            //calculamos el IMC
            //obtenemos la edad
            DateTime nacimiento = c.CLIENTE_FECHA_NAC; //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            decimal GC = 0;
            if (c.CLIENTE_SEXO == "Masculino")
                GC = ((decimal)1.2 * IMC) + ((decimal)0.23 * (decimal)edad) -((decimal)10.8 * (decimal)1) - (decimal)5.4;
            else
                GC = ((decimal)1.2 * IMC) + ((decimal)0.23 * (decimal)edad) - (decimal)5.4;

            //retornamos el resultado
            return GC;
        }*/

      
    }
}
