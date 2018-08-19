using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Da_membresias
    {
        //creacion del objeto de la base de datos
        private conexion conexion;

        public Da_membresias()
        {
            //inicializacion de la base de datos
            conexion = new conexion();
        }

        /// <summary>
        /// Metodo para registrar una nueva membresia al cliente
        /// </summary>
        /// <param name="membresias">entidad</param>
        /// <returns></returns>
        public int Registrar_membresia(Entidades.Membresias membresias)
        {
            try
            {
                int id_membresia = 0;
                if (conexion.abrirConexion())
                {
                    
                    string comando = "INSERT INTO membresia VALUES(@cli, @tipo, @fi, @ff, @cos, @desc); SELECT SCOPE_IDENTITY()";
                    SqlCommand command = new SqlCommand(comando, conexion.retornarConexion());
                    command.Parameters.Add("@cli", SqlDbType.Int);
                    command.Parameters.Add("@tipo", SqlDbType.Text);
                    command.Parameters.Add("@fi", SqlDbType.DateTime);
                    command.Parameters.Add("@ff", SqlDbType.DateTime);
                    command.Parameters.Add("@cos", SqlDbType.Float);
                    command.Parameters.Add("@desc", SqlDbType.Float);
                    command.Parameters[0].Value = membresias.cod_cliente;
                    command.Parameters[1].Value = membresias.tipo_membresia;
                    command.Parameters[2].Value = membresias.fecha_inicial;
                    command.Parameters[3].Value = membresias.fecha_final;
                    command.Parameters[4].Value = membresias.costo;
                    command.Parameters[5].Value = membresias.descuento;
                    id_membresia = Convert.ToInt32(command.ExecuteScalar());
                    conexion.cerrarConexion();
                }
                return id_membresia;
            }
            catch
            {
                return 0;
            }
            
        }

    }
}
