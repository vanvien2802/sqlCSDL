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
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "MSSV", DataType = typeof(string)},
                new DataColumn{ColumnName = "NameSV", DataType = typeof(string)},
                new DataColumn{ColumnName = "DTB", DataType = typeof(float)},
                new DataColumn{ColumnName = "ID_Lop", DataType = typeof(string)},
            });
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader r;
            cnn.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {
                dt.Rows.Add(
                    r["MSSV"].ToString(),
                    r["NameSV"].ToString(),
                    r["DTB"].ToString(),
                    r["ID_Lop"].ToString()
                    );
            }
            cnn.Close();
            return dt;
        }
    }
}
