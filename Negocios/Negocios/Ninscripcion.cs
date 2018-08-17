using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class Ninscripcion
    {
        public DataGymSisV1DataContext dt = null;
        //insertar inscripcion
       /* public int Insertar()
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                   // return this.dt.PA_Inscripciones_Insert();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        public void Editar(int id_inscripcion, int id_cliente, string programa)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                  //  this.dt.PA_inscripcion_Update(id_inscripcion, id_cliente, programa);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //eliminar cliente
        public void Eliminar(int id_inscripcion)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    //this.dt.PA_inscripcion_Delete(id_inscripcion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public object Insertar()
        {
            throw new NotImplementedException();
        }
    }
}
