using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Datos
{
    public class Da_productos
    {
        //creacion del objeto de la base de datos
        private conexion conexion;

        public Da_productos()
        {
            //inicializacion de la base de datos
            conexion = new conexion();
        }

        /// <summary>
        /// Metodo para listar los productos registrados
        /// </summary>
        /// <returns></returns>
        public DataView ListarProductos()
        {
            try
            {
                DataTable dt = new DataTable("Productos");
                if (conexion.abrirConexion())
                {

                    string consulta = "SELECT * FROM dbo.producto";
                    SqlCommand command = new SqlCommand(consulta, conexion.retornarConexion());
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(dt);
                }
                return dt.DefaultView;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Metodo para crear un producto en la base de datos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public int Crear_producto(Entidades.producto producto)
        {
            int return_id_producto = 0;
            try
            {
                if (conexion.abrirConexion())
                {

                    string comando = "INSERT INTO [dbo].[producto] VALUES (0,@nom,@desc,@stock,@compra,@venta, @stockm); SELECT SCOPE_IDENTITY()";
                    SqlCommand command = new SqlCommand(comando, conexion.retornarConexion());
                    command.Parameters.Add("@nom", SqlDbType.Text);
                    command.Parameters.Add("@desc", SqlDbType.Text);
                    command.Parameters.Add("@stock", SqlDbType.Int);
                    command.Parameters.Add("@compra", SqlDbType.Float);
                    command.Parameters.Add("@venta", SqlDbType.Float);
                    command.Parameters.Add("@stockm", SqlDbType.Int);

                    command.Parameters[0].Value = producto.nombre;
                    command.Parameters[1].Value = producto.descripcion;
                    command.Parameters[2].Value = producto.stock;
                    command.Parameters[3].Value = producto.precio_compra;
                    command.Parameters[4].Value = producto.precio_venta;
                    command.Parameters[5].Value = producto.stock_min;

                    return_id_producto = Convert.ToInt32(command.ExecuteScalar());
                    conexion.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return return_id_producto;
        }


    }
}
