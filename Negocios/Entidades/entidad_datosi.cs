using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocios
{
   public class entidad_datosi
    {
        private int cod_datos;
        private int edad;
        private double peso;
        private double talla;
        private double cuello;
        private double biceps;
        private double torax;
        private double cintura;
        private double abs;
        private double cadera;
        private double pierna;
        private double pantorilla;
        private double presion_arterial;
        private string tipo_sangre;
        private int cod_cliente;
        
        public int COD_DATOS
        {
            get
            {
                return cod_datos;
            }
            set
            {             
                this.cod_datos = value;
            }
        }
        public int EDAD
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "La edad debe ser positiva");
                this.edad = value;
            }
        }
        public double PESO
        {
            get
            {
                return peso;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "El peso debe ser positivo");
                this.peso = value;
            }
        }
        public double TALLA
        {
            get
            {
                return talla;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "La talla debe ser positivo");
                this.talla = value;
            }
        }
        public double CUELLO
        {
            get
            {
                return cuello;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "El cuello debe ser positivo");
                this.cuello = value;
            }
        }
        public double BICEPS
        {
            get
            {
                return biceps;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "Los biceps deben ser positivo");
                this.biceps = value;
            }
        }
        public double TORAX
        {
            get
            {
                return torax;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "El torax debe ser positivo");
                this.torax = value;
            }
        }
        public double CINTURA
        {
            get
            {
                return cintura;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "La cintura debe ser positivo");
                this.cintura = value;
            }
        }
        public double ABS
        {
            get
            {
                return abs;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "El abs debe ser positivo");
                this.abs = value;
            }
        }
        public double CADERA
        {
            get
            {
                return cadera;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "La cadera debe ser positivo");
                this.cadera = value;
            }
        }
        public double PIERNA
        {
            get
            {
                return pierna;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "La pierna debe ser positivo");
                this.pierna = value;
            }
        }
        public double PANTORRILLA
        {
            get
            {
                return pantorilla;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "La pantorrilla debe ser positivo");
                this.pantorilla = value;
            }
        }
        public double PRESION_ARTERIAL
        {
            get
            {
                return presion_arterial;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value", "La presion arterial debe ser positivo");
                this.presion_arterial = value;
            }
        }
        public string TIPO_SANGRE
        {
            get
            {
                return tipo_sangre;
            }
            set
            {
                this.tipo_sangre = value;
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
                this.cod_cliente = value;
            }
        }
    }

}
