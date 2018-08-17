using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocios
{
    public class Nmembresia
    {
        public DataGymSisV1DataContext dt = null;
        //mostrar todas las subscripciones
        public List<membresias> ListarMembresias()
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = from c in this.dt.membresias
                            select c;
                    return t.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }

        public List<membresia> ListarMembresia(int cliente)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = from c in this.dt.membresia
                            where c.cod_cliente.Equals(cliente)
                            select c;
                    return t.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }

        //biscar cliente por nombre
        public List<clientes_subscripciones> ListarSubs(DateTime inicio, DateTime fin)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = from c in this.dt.clientes_subscripciones
                            where (c.INICIO >= inicio.Date && c.TERMINA <= fin.Date)
                            select c;
                    return t.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }



           //insertar
        public int Insertar(entidad_membresia ec)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    return this.dt.membresia_insert(ec.COD_CLIENTE, ec.TIPO_MEMBRESIA, ec.FECHA_INICIAL, ec.FECHA_FINAL, ec.COSTO, ec.DESCUENTO);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //editar
       /* public int Editar(entidad_membresia ec)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    //return this.dt.PA_membresia_Update(ec.MEMBRESIA_ID_MEMBRESIA, ec.TIPO_MEMBRESIA, ec.FECHA_INICIAL, ec.FECHA_FINAL, ec.COSTO, ec.DESCUENTO);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
        //eliminar
        public void Eliminar(int codigo)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    this.dt.PA_membresia_Delete(codigo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   

    }
}
