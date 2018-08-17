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
    class VentaDao : AbstractDao
    {
        private ConexionPostreSql conexionPostgreSql;
        private int filasAfectadas;

        public VentaDao() 
        {
            this.conexionPostgreSql = new ConexionPostreSql();
        }


        public override int crear(object o)
        {
            Venta venta = (Venta)o;
            int lastIdVenta = 0;
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {

                    string consulta = "INSERT INTO venta(total, fecha, anulada) VALUES(@Total, @Fecha, @Anulada); ; SELECT SCOPE_IDENTITY()";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    command.Parameters.Add("@Total", SqlDbType.Int);
                    command.Parameters.Add("@Fecha", SqlDbType.DateTime);
                    command.Parameters.Add("@Anulada", SqlDbType.Bit);
                    command.Parameters[0].Value = venta.Total;
                    command.Parameters[1].Value = venta.Fecha;
                    command.Parameters[2].Value = venta.Anulada;
                    lastIdVenta = Convert.ToInt32(command.ExecuteScalar());
                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lastIdVenta;
        }

        public override int editar(object o)
        {
            throw new NotImplementedException();
        }

        public override int cambiarEstado(string id, bool anulado)
        {
            anulado = true;
            bool anuloVenta = false;
            bool anuloDetalle = false;
            bool devolvioStock = false;

            this.filasAfectadas = 0;

            if (conexionPostgreSql.abrirConexion())
            {
                //SqlTransaction anularVentaTransaction = null;
                SqlTransaction transaction;
                SqlCommand command = conexionPostgreSql.retornarConexion().CreateCommand();
                // Start a local transaction.
                transaction = conexionPostgreSql.retornarConexion().BeginTransaction("antesDeAnularVenta");
                // Must assign both transaction object and connection 
                // to Command object for a pending local transaction
                command.Connection = conexionPostgreSql.retornarConexion();
                command.Transaction = transaction;

                List<DetalleVenta> detallesQueContieneProductos = new List<DetalleVenta>();

                try
                {

                    //anularVentaTransaction = conexionPostgreSql.retornarConexion().BeginTransaction();
                    //anularVentaTransaction.Save("antesDeAnularVenta");
                    

                    try
                    {
                        string consultaVenta = "UPDATE venta set anulada = '"+ anulado.ToString().ToLower() + "' WHERE idventa = " + id;
                        command.CommandText = consultaVenta;
                        //SqlCommand commandVenta = new SqlCommand(consultaVenta, conexionPostgreSql.retornarConexion(), transaction);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            anuloVenta = true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        anuloVenta = false;
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();

                    }

                    try
                    {
                        string consultaDetalle = "UPDATE detalleventa set anulado = '" + anulado.ToString().ToLower() + "' WHERE idventa = "+ id;
                        command.CommandText = consultaDetalle;
                        //SqlCommand commandDetalle = new SqlCommand(consultaDetalle, conexionPostgreSql.retornarConexion());
                        if (command.ExecuteNonQuery() >= 1)
                        {
                            anuloDetalle = true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        anuloDetalle = false;
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();
                        //anularVentaTransaction.Rollback("antesDeAnularVenta");
                    }

                    try
                    {
                        string consultaDetallePorProductos = "SELECT idproducto, cantidad FROM detalleventa WHERE idventa = " + id;
                        command.CommandText = consultaDetallePorProductos;
                        //SqlCommand commandBuscarDetalles = new SqlCommand(consultaDetallePorProductos, conexionPostgreSql.retornarConexion());
                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            detallesQueContieneProductos.Add(
                                new DetalleVenta
                                {
                                    IdProducto = dataReader[0].ToString(),
                                    Cantidad = Convert.ToInt32(dataReader[1])
                                });
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                        transaction.Rollback();
                        //anularVentaTransaction.Rollback("antesDeAnularVenta");
                    }

                    transaction.Commit();

                    try
                    {
                        foreach (var item in detallesQueContieneProductos)
                        {
                            string consultaProductos = "UPDATE producto SET stock = stock + " + item.Cantidad + " WHERE idproducto = '" + item.IdProducto + "'";
                            //command.CommandText = consultaProductos;
                            SqlCommand commandProductos = new SqlCommand(consultaProductos, conexionPostgreSql.retornarConexion());
                            if (commandProductos.ExecuteNonQuery() >= 1)
                            {
                                devolvioStock = true;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        devolvioStock = false;
                        MessageBox.Show(ex.ToString());
                        //anularVentaTransaction.Rollback("antesDeAnularVenta");
                        transaction.Rollback();

                    }

                    //anularVentaTransaction.Commit();
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    //anularVentaTransaction.Rollback();
                }
                finally 
                {
                    conexionPostgreSql.cerrarConexion();
                }
            }

            if (anuloVenta && anuloDetalle && devolvioStock) 
            {
                this.filasAfectadas = 1;
            }

            return this.filasAfectadas;
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

            ArrayList ventas = new ArrayList();
            try
            {
                if (conexionPostgreSql.abrirConexion())
                {
                    
                    string consulta = "SELECT idventa, total, fecha FROM venta WHERE anulada = 'false' AND (STR(idventa) LIKE '%" + buscar + "%'"
                        + " OR STR(total) LIKE '%" + buscar + "%' OR CAST(fecha AS varchar(10)) LIKE '%" + buscar + "%') order by idventa DESC OFFSET " + offset + "ROWS FETCH NEXT " + finalLimit + " ROWS ONLY";
                    SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {
                            ventas.Add(
                                new Venta
                                {
                                    IdVenta = Convert.ToInt32(dataReader[0]),
                                    Total = Convert.ToInt32(dataReader[1]),
                                    Fecha = (DateTime)dataReader[2]
                                });
                        }
                    }
                    conexionPostgreSql.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ventas;
        }

        public override object buscar(string id)
        {
            Venta venta = new Venta();
            if (conexionPostgreSql.abrirConexion())
            {
                //string consulta = "SELECT last_value FROM venta_idventa_seq";
                string consulta = "SELECT COUNT(idventa) FROM venta";
                SqlCommand command = new SqlCommand(consulta, conexionPostgreSql.retornarConexion());
                venta.IdVenta = Convert.ToInt32(command.ExecuteScalar());
                conexionPostgreSql.cerrarConexion();
            }
            return venta;
        }

        public override int eliminar(string id)
        {
            throw new NotImplementedException();
        }
    }
}
