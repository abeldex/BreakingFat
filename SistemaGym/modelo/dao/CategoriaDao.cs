using ControlVentas.modelo.poco;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows;

namespace ControlVentas.modelo.dao
{
    class CategoriaDao : AbstractDao
    {

        private ConexionPostreSql conexionPostgreSql;
        private int filasAfectadas;

        public CategoriaDao() 
        {
            this.conexionPostgreSql = new ConexionPostreSql();
        }

        public override int crear(object o)
        {
            Categoria categoria = (Categoria)o;
            this.filasAfectadas = 0;
            try 
            { 
                if(conexionPostgreSql.abrirConexion())
                {

                    string consulta = "INSERT INTO categoria(nombre) VALUES(@nombre)";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                    command.Parameters[0].Value = categoria.Nombre;
                    this.filasAfectadas = command.ExecuteNonQuery();
                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
           return this.filasAfectadas;
        }

        public override int editar(object o)
        {
            Categoria categoria = (Categoria)o;
            this.filasAfectadas = 0;
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    string consulta = "UPDATE categoria set nombre = @nombre WHERE idcategoria = @idCategoria";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@idCategoria", SqlDbType.Int);
                    command.Parameters[0].Value = categoria.Nombre;
                    command.Parameters[1].Value = categoria.IdCategoria;
                    this.filasAfectadas = command.ExecuteNonQuery();
                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return this.filasAfectadas;
        }

        public override int cambiarEstado(string id, bool vigente)
        {
            throw new NotImplementedException();
        }

        public override ArrayList ver(int[] arreglo, string buscar)
        {
            int limit = arreglo[0];
            int offset = arreglo[1];

            string finalLimit = "";

            if (limit == -1)
            {
                finalLimit = "1000";
            }
            else
            {
                finalLimit = limit.ToString();
            }

            ArrayList categorias = new ArrayList();
            try 
            {
                if(conexionPostgreSql.abrirConexion())
                {
                    string consulta = "SELECT idcategoria, nombre FROM categoria WHERE nombre LIKE '%" + buscar + "%' order by idcategoria OFFSET " + offset + "ROWS FETCH NEXT " + finalLimit + " ROWS ONLY";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read()) 
                    {
                        categorias.Add(
                            new Categoria 
                            { 
                                IdCategoria = Convert.ToInt32(dataReader[0]),
                                Nombre = dataReader[1].ToString()
                            });
                    }
                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return categorias;
        }

        public override object buscar(string id)
        {
            throw new NotImplementedException();
        }

        public override int eliminar(string id)
        {
            this.filasAfectadas = 0;
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    string consultaProducto = "SELECT idcategoria FROM  producto WHERE producto.idcategoria = @IdCategoria";
                    SqlCommand commandProducto = new SqlCommand(consultaProducto, conexionPostgreSql.retornarConexion());
                    commandProducto.Parameters.Add("@IdCategoria", SqlDbType.Int);
                    commandProducto.Parameters[0].Value = Convert.ToInt32(id);
                    SqlDataReader reader = commandProducto.ExecuteReader();

                    if (reader.HasRows == false)
                    {
                        string consulta = "DELETE FROM categoria WHERE idcategoria = @idCategoria";
                        SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                        command.Parameters.Add("@idCategoria", SqlDbType.Int);
                        command.Parameters[0].Value = Convert.ToInt32(id);
                        this.filasAfectadas = command.ExecuteNonQuery();                     
                    }
                    else 
                    {
                        this.filasAfectadas = 0;
                    }

                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return this.filasAfectadas;
           
        }
    }
}
