using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string MSSV, NameSV, ID_Lop;
        float DTB;
        private void button1_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=DESKTOP-530ACSJ;Initial Catalog=QLSV;Integrated Security=True";
            DBHelper db = new DBHelper(s);
            string query = "Select * from SV";
            dataGridView1.DataSource = db.GetRecordSV(query);


            //SqlConnection cnn = new SqlConnection(s);
            ////string query = "INSERT INTO SV (MSSV, NameSv, DTB,ID_Lop) VALUES(7, 'Pham Van Tien Truong7', 7.6, 1); ";
            ////string query = "Select * from SV Where NameSV ='"+textBox1.Text+"'";
            //SqlParameter p = new SqlParameter
            //{
            //    ParameterName = "@Name",
            //    Value = textBox1.Text
            //};
            //string query = "Select * from SV Where NameSV = @Name";
            //SqlCommand cmd = new SqlCommand(query, cnn);
            //cmd.Parameters.Add(p);
            //cnn.Open();
            ////int n = (int)cmd.ExecuteScalar();
            ////cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[]
            //{
            //    new DataColumn{ColumnName = "MSSV", DataType = typeof(string)},
            //    new DataColumn{ColumnName = "NameSV", DataType = typeof(string)},
            //    new DataColumn{ColumnName = "DTB", DataType = typeof(float)},
            //    new DataColumn{ColumnName = "ID_Lop", DataType = typeof(string)},
            //});
            //SqlDataReader r;
            //r = cmd.ExecuteReader();
            //while (r.Read())
            //{
            //    dt.Rows.Add(
            //        r["MSSV"].ToString(),
            //        r["NameSV"].ToString(),
            //        r["DTB"].ToString(),
            //        r["ID_Lop"].ToString()
            //        );
            //}
            //cnn.Close();
            //dataGridView1.DataSource = dt;
        }
    }
}
