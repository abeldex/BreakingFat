using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class Ndatosi
    {
        public DataGymSisV1DataContext dt = null;

        public int Insertar(entidad_datosi ec)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    return this.dt.PA_datos_importantes_INSERT(ec.EDAD, ec.PESO, ec.TALLA, ec.CUELLO, ec.BICEPS, ec.TORAX, ec.CINTURA, ec.ABS, ec.CADERA, ec.PIERNA, ec.PANTORRILLA, ec.PRESION_ARTERIAL, ec.TIPO_SANGRE, ec.COD_CLIENTE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //editar
        public int Editar(entidad_datosi ec)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    return this.dt.PA_datos_importantes_UPDATE(ec.EDAD, ec.PESO, ec.TALLA, ec.CUELLO, ec.BICEPS, ec.TORAX, ec.CINTURA, ec.ABS, ec.CADERA, ec.PIERNA, ec.PANTORRILLA, ec.PRESION_ARTERIAL, ec.TIPO_SANGRE, ec.COD_CLIENTE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public entidad_datosi GetDatosImportantes(int codigo)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = (from datosi in this.dt.datos_importantes
                             where datosi.cod_cliente.Equals(codigo)
                             select new { datosi }).Single();
                    entidad_datosi d = new entidad_datosi()
                    {
                        COD_DATOS = t.datosi.cod_datos,
                        EDAD = t.datosi.edad,
                        PESO = t.datosi.peso,
                        TALLA = t.datosi.talla,
                        CUELLO = t.datosi.cuello,
                        BICEPS = t.datosi.biceps,
                        TORAX = t.datosi.torax,
                        CINTURA = t.datosi.cintura,
                        ABS = t.datosi.abs,
                        CADERA = t.datosi.cadera,
                        PIERNA = t.datosi.pierna,
                        PANTORRILLA = t.datosi.pantorrilla,
                        PRESION_ARTERIAL = t.datosi.presion_arterial,
                        COD_CLIENTE = t.datosi.cod_cliente,
                        TIPO_SANGRE = t.datosi.tipo_sangre
                    };
                    return d;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
