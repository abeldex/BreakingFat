using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SistemaGym
{
    public delegate void OnChangeHandler();

    public class AppData
    {
        public const int MaxFingers = 10;
        // shared data
        public String Cs = ConfigurationManager.ConnectionStrings["saffron.GYM.GYM2"].ConnectionString;
        //inicializamos
        public int EnrolledFingersMask = 0;
        public int MaxEnrollFingerCount = MaxFingers;
        public bool IsEventHandlerSucceeds = true;
        public bool IsFeatureSetMatched = false;
        public int FalseAcceptRate = 0;
        public DPFP.Template[] Templates = new DPFP.Template[MaxFingers - 1];

        public AppData(int id)
        {
            actualizar(id);
        }

        public void actualizar(int id)
        {
            SqlConnection objConn = new SqlConnection(Cs);
            objConn.Open();
            //'EnrolledFingerMask
            //'FINGERS
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add();
            String sSQL = "SELECT EnrolledFingerMask from cliente where cod_cliente = " + id;
            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            try
            {
                objCmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(objCmd);
                da.Fill(dt);
                EnrolledFingersMask = Convert.ToInt16(dt.Rows[0][0]);
                Console.WriteLine("Records Ready");
            }
            catch (Exception)
            {
                throw;
            }
            objConn.Close();

        }

        // data change notification
        public void Update() { OnChange(); }

        // just fires the OnChange() event
        public event OnChangeHandler OnChange;
    }
}
