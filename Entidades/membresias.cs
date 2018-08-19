using System;

namespace Entidades
{
    public class Membresias
    {
        public int id_membresia { get; set; }
        public int cod_cliente { get; set; }
        public string tipo_membresia { get; set; }
        public DateTime fecha_inicial { get; set; }
        public DateTime fecha_final { get; set; }
        public float costo { get; set; }
        public float descuento { get; set; }
    }
}
