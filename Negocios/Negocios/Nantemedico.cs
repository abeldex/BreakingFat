using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocios
{
    public class Nantemedico
    {
        public DataGymSisV1DataContext dt = null;

        //biscar cliente por nombre
        public List<antecedentes_medicos> ListarAntecedentesMedicos(int codigo)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = from c in this.dt.antecedentes_medicos
                            where c.cod_cliente.Equals(codigo)
                            select c;
                    return t.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }


        public int Insertar(entidad_antmedico ec)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    return this.dt.PA_antecedentes_INSERT(ec.ANTECEDENTES_DESC, ec.DESCRIPCOPM_TIPO, ec.COD_CLIENTE);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //obtener datos cliente
        public entidad_antmedico GetAntecedentesMedicos(int codigo)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = (from am in this.dt.antecedentes_medicos
                             where am.cod_cliente.Equals(codigo)
                             select new { am }).Single();
                    entidad_antmedico a = new entidad_antmedico()
                    {
                        ANTECEDENTES_DESC = t.am.antecedente_desc,
                        DESCRIPCOPM_TIPO = t.am.descripcion_tipos,                       
                    };
                    return a;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }

}