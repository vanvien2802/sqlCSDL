using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNCSDL
{

    public class DBHelper
    {
        private SqlConnection cnn;
        public DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }

        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query,cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecordSV(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,cnn);
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
