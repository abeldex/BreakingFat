using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Datos
{
    public class da_clientes
    {
        private conexion conexion;

        public da_clientes()
        {
            conexion = new conexion();
        }

        public object obtener_datos(int codigo)
        {
            clientes cliente = new clientes();
            try
            {
                if (conexion.abrirConexion())
                {
                    //conexionPostgreSql.retornarConexion().BeginTransaction();
                    string consulta = "SELECT * FROM dbo.cliente WHERE cod_cliente = "+codigo;
                    SqlCommand command = new SqlCommand(consulta, conexion.retornarConexion());
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cliente.CLIENTE_COD = Convert.ToInt32(dataReader[0]);
                        cliente.CLIENTE_NOMBRE = Convert.ToString(dataReader[1]);
                        cliente.CLIENTE_DIRECCION = Convert.ToString(dataReader[2]);
                        cliente.CLIENTE_CIUDAD = Convert.ToString(dataReader[3]);
                        cliente.CLIENTE_TELEFONO = Convert.ToString(dataReader[4]);
                        cliente.CLIENTE_SEXO = Convert.ToString(dataReader[5]);
                        cliente.CLIENTE_CORREO = Convert.ToString(dataReader[6]);
                        cliente.CLIENTE_FECHA_NAC = Convert.ToDateTime(dataReader[7]);

                        if (dataReader[9] != DBNull.Value) {cliente.CLIENTE_ALTURA = Convert.ToDecimal(dataReader[9]); } else { cliente.CLIENTE_ALTURA = 0; }
                           
                        if (dataReader[10] != DBNull.Value) {cliente.CLIENTE_PESO = Convert.ToDecimal(dataReader[10]); } else { cliente.CLIENTE_PESO = 0; }
                        if (dataReader[11] != DBNull.Value) {cliente.CLIENTE_CUELLO = Convert.ToDecimal(dataReader[11]); } else { cliente.CLIENTE_CUELLO = 0; }
                        if (dataReader[12] != DBNull.Value) {cliente.CLIENTE_TORAX = Convert.ToDecimal(dataReader[12]); } else { cliente.CLIENTE_TORAX = 0; }
                        if (dataReader[13] != DBNull.Value) {cliente.CLIENTE_BRAZO = Convert.ToDecimal(dataReader[13]); } else { cliente.CLIENTE_BRAZO = 0; }
                        if (dataReader[14] != DBNull.Value) {cliente.CLIENTE_CINTURA = Convert.ToDecimal(dataReader[14]); } else { cliente.CLIENTE_CINTURA = 0; }
                        if (dataReader[15] != DBNull.Value) {cliente.CLIENTE_CADERA = Convert.ToDecimal(dataReader[15]); } else { cliente.CLIENTE_CADERA = 0; }
                        if (dataReader[16] != DBNull.Value) {cliente.CLIENTE_PIERNA = Convert.ToDecimal(dataReader[16]); } else { cliente.CLIENTE_PIERNA = 0; }
                        if (dataReader[17] != DBNull.Value) {cliente.CLIENTE_PANTORRILLA = Convert.ToDecimal(dataReader[17]); } else { cliente.CLIENTE_PANTORRILLA = 0; }

                    }
                    conexion.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cliente;
        }

        public int Crear_cliente(Entidades.clientes cliente)
        {
            //clientes cliente = (clientes)o;
            int return_id_cliente = 0;
            try
            {
                if (conexion.abrirConexion())
                {

                    string comando = "INSERT INTO [dbo].[cliente] VALUES (@nom, @dir,@ciu,@tel,@sex,@mail,@nac,0,@alt,@pe,@cue,@tor,@bra,@cin,@cad,@pie,@pant); SELECT SCOPE_IDENTITY()";
                    SqlCommand command = new SqlCommand(comando, conexion.retornarConexion());
                    command.Parameters.Add("@nom", SqlDbType.Text);
                    command.Parameters.Add("@dir", SqlDbType.Text);
                    command.Parameters.Add("@ciu", SqlDbType.Text);
                    command.Parameters.Add("@tel", SqlDbType.Text);
                    command.Parameters.Add("@sex", SqlDbType.Text);
                    command.Parameters.Add("@mail", SqlDbType.Text);
                    command.Parameters.Add("@nac", SqlDbType.Date);
                    command.Parameters.Add("@alt", SqlDbType.Decimal);
                    command.Parameters.Add("@pe", SqlDbType.Decimal);
                    command.Parameters.Add("@cue", SqlDbType.Decimal);
                    command.Parameters.Add("@tor", SqlDbType.Decimal);
                    command.Parameters.Add("@bra", SqlDbType.Decimal);
                    command.Parameters.Add("@cin", SqlDbType.Decimal);
                    command.Parameters.Add("@cad", SqlDbType.Decimal);
                    command.Parameters.Add("@pie", SqlDbType.Decimal);
                    command.Parameters.Add("@pant", SqlDbType.Decimal);
                    command.Parameters[0].Value = cliente.CLIENTE_NOMBRE;
                    command.Parameters[1].Value = cliente.CLIENTE_DIRECCION;
                    command.Parameters[2].Value = cliente.CLIENTE_CIUDAD;
                    command.Parameters[3].Value = cliente.CLIENTE_TELEFONO;
                    command.Parameters[4].Value = cliente.CLIENTE_SEXO;
                    command.Parameters[5].Value = cliente.CLIENTE_CORREO;
                    command.Parameters[6].Value = cliente.CLIENTE_FECHA_NAC;
                    command.Parameters[7].Value = cliente.CLIENTE_ALTURA;
                    command.Parameters[8].Value = cliente.CLIENTE_PESO;
                    command.Parameters[9].Value = cliente.CLIENTE_CUELLO;
                    command.Parameters[10].Value = cliente.CLIENTE_TORAX;
                    command.Parameters[11].Value = cliente.CLIENTE_BRAZO;
                    command.Parameters[12].Value = cliente.CLIENTE_CINTURA;
                    command.Parameters[13].Value = cliente.CLIENTE_CADERA;
                    command.Parameters[14].Value = cliente.CLIENTE_PIERNA;
                    command.Parameters[15].Value = cliente.CLIENTE_PANTORRILLA;

                    return_id_cliente = Convert.ToInt32(command.ExecuteScalar());
                    conexion.cerrarConexion();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return return_id_cliente;
        }
    }
}
