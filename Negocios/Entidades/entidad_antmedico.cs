using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class entidad_antmedico
    {
        private int cod_antecedentes;
        private string antecedente_desc;
        private string descripcion_tipo;
        private int cod_cliente;

        public int COD_ANTECEDENTES
        {
            get
            {
                return cod_antecedentes;
            }
            set
            {
                this.cod_antecedentes = value;
            }
        }

        public string ANTECEDENTES_DESC
        {
            get
            {
                return antecedente_desc;
            }
            set
            {
                this.antecedente_desc = value;
            }
        }
        public string DESCRIPCOPM_TIPO
        {
            get
            {
                return descripcion_tipo;
            }
            set
            {
                this.descripcion_tipo = value;
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
