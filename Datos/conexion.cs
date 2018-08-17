using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Datos
{
    public class conexion //: AbstractConexion
    {

        private SqlConnection sqlConnection;

        public conexion()
        {
            sqlConnection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=GYM;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        public bool abrirConexion()
        {
            try
            {
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.MessageBox.Show("Error de coexión con la base de datos:" + ex.ToString(), "Mensaje del sistema", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                sqlConnection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.MessageBox.Show(ex.ToString(), "Mensaje del sistema", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        public SqlConnection retornarConexion()
        {
            return sqlConnection;
        }
    }
}
