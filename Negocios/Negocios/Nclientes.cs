using System;
using System.Collections.Generic;
using System.Linq;
using Datos;

namespace Negocios
{
    public class Nclientes
    {
        public DataGymSisV1DataContext dt = null;
        //biscar cliente por nombre
        public List<VistaClientes> ListarClientes(String @buscar)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = from c in this.dt.VistaClientes
                            where c.NOMBRE.Contains(buscar)
                            select c;
                    return t.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }

        public int Insertar(entidad_clientes ec)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    return this.dt.PA_clientes_Insert(ec.CLIENTE_NOMBRE, ec.CLIENTE_DIRECCION,ec.CLIENTE_CIUDAD,ec.CLIENTE_TELEFONO,ec.CLIENTE_SEXO,ec.CLIENTE_CORREO,ec.CLIENTE_FECHA_NAC, ec.HUELLA);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //editar cliente
        public void Editar(entidad_clientes ec)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    this.dt.PA_clientes_Update(ec.CLIENTE_NOMBRE, ec.CLIENTE_DIRECCION,ec.CLIENTE_CIUDAD,ec.CLIENTE_TELEFONO,ec.CLIENTE_SEXO,ec.CLIENTE_CORREO,ec.CLIENTE_FECHA_NAC, ec.CLIENTE_COD_CLIENTE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //eliminar cliente
        public void Eliminar(int codigo)
        {
            try
            {
                using (this.dt = new DataGymSisV1DataContext())
                {
                    this.dt.PA_clientes_Delete(codigo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }      
        //obtener datos cliente
        public entidad_clientes GetDatosPersonales(int codigo)
        {
            try
            {

                using (this.dt = new DataGymSisV1DataContext())
                {
                    var t = (from cli in this.dt.cliente
                             where cli.cod_cliente.Equals(codigo)
                             select new { cli }).Single();
                    entidad_clientes c = new entidad_clientes()
                    {
                        CLIENTE_COD_CLIENTE = t.cli.cod_cliente,
                        CLIENTE_NOMBRE = t.cli.nombre,
                        CLIENTE_DIRECCION = t.cli.direccion,
                        CLIENTE_CIUDAD = t.cli.ciudad,
                        CLIENTE_TELEFONO = t.cli.telefono,
                        CLIENTE_SEXO = t.cli.sexo,
                        CLIENTE_CORREO = t.cli.correo,
                        CLIENTE_FECHA_NAC = t.cli.fecha_nac,
                    };
                    return c;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
    
}
