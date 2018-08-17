using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocios
{
    public class entidad_membresia
    {
        private int membresia_id_membresia;
        private int cod_cliente;
        private string tipo_membresia;
        private DateTime fecha_inicial;
        private DateTime fecha_final;
        private float costo;
        private float descuento;

        public int MEMBRESIA_ID_MEMBRESIA
        {
            get
            {
                return membresia_id_membresia;
            }
            set
            {
                this.membresia_id_membresia = value;
            }
        }

        public int COD_CLIENTE
        {
            get
            {
                return cod_cliente;
            }
            set
            {
                this.cod_cliente= value;
            }
        }
        public string TIPO_MEMBRESIA
        {
            get
            {
                return tipo_membresia;
            }
            set
            {
                this.tipo_membresia = value;
            }
        }
        public DateTime FECHA_INICIAL
        {
            get
            {
                return fecha_inicial;
            }
            set
            {
                this.fecha_inicial = value;
            }
        }
        public DateTime FECHA_FINAL
        {
            get
            {
                return fecha_final;
            }
            set
            {
                this.fecha_final = value;
            }
        }
        public float COSTO
        {
            get
            {
                return costo;
            }
            set
            {
                this.costo = value;
            }
        }
        public float DESCUENTO
        {
            get
            {
                return descuento;
            }
            set
            {
                this.descuento = value;
            }
        }
    }
}
