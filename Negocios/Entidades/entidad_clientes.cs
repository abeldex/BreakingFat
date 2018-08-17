using System;
namespace Negocios
{
    public class entidad_clientes
    {
        private int cliente_cod_cliente;
        private string cliente_nombre;
        private string cliente_direccion;
        private string cliente_ciudad;
        private string cliente_telefono;
        private string cliente_sexo;
        private string cliente_correo;
        private DateTime cliente_fecha_nac;
        private decimal altura;
        private decimal peso;
        private decimal cuello;
        private decimal torax;
        private decimal brazo;
        private decimal cintura;
        private decimal cadera;
        private decimal pierna;
        private decimal pantorrilla;

        public decimal CLIENTE_PESO { get; set; }
        public decimal CLIENTE_CUELLO { get; set; }
        public decimal CLIENTE_TORAX { get; set; }
        public decimal CLIENTE_BRAZO { get; set; }
        public decimal CLIENTE_CINTURA { get; set; }
        public decimal CLIENTE_CADERA { get; set; }
        public decimal CLIENTE_PIERNA { get; set; }
        public decimal CLIENTE_PANTORRILLA { get; set; }
        private int huella;
        public decimal CLIENTE_ALTURA
        {
            get
            {
                return this.altura;
            }
            set
            {
                this.altura = value;
            }
        }

        public int CLIENTE_COD_CLIENTE
        {
            get
            {
                return cliente_cod_cliente;
            }
            set
            {
                this.cliente_cod_cliente = value;
            }
        }
        public string CLIENTE_NOMBRE
        {
            get
            {
                return cliente_nombre;
            }
            set
            {
                this.cliente_nombre = value;
            }
        }
        public string CLIENTE_DIRECCION
        {
            get
            {
                return cliente_direccion;
            }
            set
            {
                this.cliente_direccion = value;
            }
        }
        public string CLIENTE_CIUDAD
        {
            get
            {
                return cliente_ciudad;
            }
            set
            {
                this.cliente_ciudad = value;
            }
        }
        public string CLIENTE_TELEFONO
        {
            get
            {
                return cliente_telefono;
            }
            set
            {
                this.cliente_telefono = value;
            }
        }
        public string CLIENTE_SEXO
        {
            get
            {
                return cliente_sexo;
            }
            set
            {
                this.cliente_sexo = value;
            }
        }
        public string CLIENTE_CORREO
        {
            get
            {
                return cliente_correo;
            }
            set
            {
                this.cliente_correo = value;
            }
        }
        public DateTime CLIENTE_FECHA_NAC
        {
            get
            {
                return cliente_fecha_nac;
            }
            set
            {
                this.cliente_fecha_nac = value;
            }
        }
        public int HUELLA
        {
            get
            {
                return huella;
            }
            set
            {
                this.huella = value;
            }
        }

        public entidad_antmedico entidad_antmedico
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public entidad_datosi entidad_datosi
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

    }

}
