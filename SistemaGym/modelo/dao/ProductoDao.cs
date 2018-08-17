using ControlVentas.modelo.poco;
using System.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace ControlVentas.modelo.dao
{
    class ProductoDao : AbstractDao
    {
        private ConexionPostreSql conexionPostgreSql;
        private int filasAfectadas;

        public ProductoDao() 
        {
            this.conexionPostgreSql = new ConexionPostreSql();
        }

        public override int crear(object o)
        {
            Producto producto = (Producto)o;
            this.filasAfectadas = 0;
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    string consulta = "INSERT INTO producto(idproducto, idcategoria, nombre, descripcion, stock, preciocompra, precioventa) " 
                    + "VALUES(" + producto.IdProducto + "," + producto.IdCategoria + ", '" + producto.Nombre + "','" + producto.Descripcion 
                    + "', "+ producto.Stock +", " + producto.PrecioCompra + ", " + producto.PrecioVenta+ ")";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
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

        public override int editar(object o)
        {
            Producto producto = (Producto)o;
            this.filasAfectadas = 0;
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    string consulta = "UPDATE producto set idcategoria = @IdCategoria, nombre = @Nombre, descripcion = @Descripcion, stock = @Stock, "
                        + "preciocompra = @PrecioCompra, precioventa = @PrecioVenta WHERE idproducto = @Idproducto";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    command.Parameters.Add("@IdCategoria", SqlDbType.Int);
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100);
                    command.Parameters.Add("@Stock", SqlDbType.Int);
                    command.Parameters.Add("@PrecioCompra", SqlDbType.Int);
                    command.Parameters.Add("@PrecioVenta", SqlDbType.Int);
                    command.Parameters.Add("@IdProducto", SqlDbType.VarChar, 20);
                    command.Parameters[0].Value = producto.IdCategoria;
                    command.Parameters[1].Value = producto.Nombre;
                    command.Parameters[2].Value = producto.Descripcion;
                    command.Parameters[3].Value = producto.Stock;
                    command.Parameters[4].Value = producto.PrecioCompra;
                    command.Parameters[5].Value = producto.PrecioVenta;
                    command.Parameters[6].Value = producto.IdProducto;
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


            ArrayList productos = new ArrayList();
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    string consulta = "SELECT p.idproducto, c.nombre, p.nombre, p.descripcion, p.stock, p.preciocompra, p.precioventa " 
                    +"FROM producto p INNER JOIN categoria c ON p.idcategoria = c.idcategoria WHERE (c.nombre LIKE '%" + buscar + "%'" 
                    +" OR p.nombre LIKE '%" + buscar + "%' OR p.idproducto LIKE '%" + buscar + "%') order by p.idproducto OFFSET " + offset + "ROWS FETCH NEXT " + finalLimit + " ROWS ONLY";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        productos.Add(
                            new Producto
                            {
                                IdProducto = dataReader[0].ToString(),
                                Categoria = dataReader[1].ToString(),
                                Nombre = dataReader[2].ToString(),
                                Descripcion = dataReader[3].ToString(),
                                Stock = Convert.ToInt32(dataReader[4]),
                                PrecioCompra = Convert.ToInt32(dataReader[5]),
                                PrecioVenta = Convert.ToInt32(dataReader[6])
                            });
                    }
                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return productos;
        }

        public override object buscar(string id)
        {
            Producto producto = new Producto();
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    string consulta = "SELECT nombre, stock, precioventa FROM producto WHERE idproducto = @IdProducto";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    command.Parameters.Add("@IdProducto", SqlDbType.VarChar, 20);
                    command.Parameters[0].Value = id;
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        producto.Nombre = dataReader[0].ToString();
                        producto.Stock = Convert.ToInt32(dataReader[1]);
                        producto.PrecioVenta = Convert.ToInt32(dataReader[2]);
                    }
                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return producto;
        }

        public override int eliminar(string id)
        {
            this.filasAfectadas = 0;
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    string consultaDetalle = "SELECT idproducto FROM detalleventa WHERE detalleventa.idproducto = @IdProducto";
                    SqlCommand commandDetalle = new SqlCommand(consultaDetalle, conexionPostgreSql.retornarConexion());
                    commandDetalle.Parameters.Add("@IdProducto", SqlDbType.VarChar, 20);
                    commandDetalle.Parameters[0].Value = id;
                    SqlDataReader reader = commandDetalle.ExecuteReader();

                    if (reader.HasRows == false)
                    {
                        string consulta = "DELETE FROM producto WHERE idproducto = @IdProducto";
                        SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                        command.Parameters.Add("@IdProducto", SqlDbType.VarChar, 20);
                        command.Parameters[0].Value = id;
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
