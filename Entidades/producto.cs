using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class producto
    {
        public int idproducto { get; set; }
        public int idcategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public float precio_compra { get; set; }
        public float precio_venta { get; set; }
        public int stock_min { get; set; }
    }
}
