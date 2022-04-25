using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap22032022
{
    public partial class MainForm : Form
    {
        QLSV db = new QLSV();
        public MainForm()
        {
            InitializeComponent();
            comboBox_lopsinhhoat.Items.Add("All");
            foreach(string i in db.Get_Class().Distinct())
            {
                comboBox_lopsinhhoat.Items.Add(i);
            }
            comboBox_direct.SelectedIndex = 0;
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string data = comboBox_lopsinhhoat.Text;
            ShowAll(data, "");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm("");
            f.d = new DetailForm.MyDel(ShowAll);
            f.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string s = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
                DetailForm f = new DetailForm(s);
                f.d = new DetailForm.MyDel(ShowAll);
                f.Show();
            }
        }
        public void ShowAll(string s, string txt )
        {
            dataGridView1.DataSource = db.Search(s, txt);
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                List<Sv> s = new List<Sv>();
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    s.Add(db.GetSvByMssv(i.Cells["MSSV"].Value.ToString()));
                }
                db.Del(s);
                ShowAll(comboBox_lopsinhhoat.SelectedItem.ToString(), "");
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string txt = textBox_search.Text;
            ShowAll(comboBox_lopsinhhoat.SelectedItem.ToString(), txt);
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            List<string> s = new List<string>();
            foreach(DataGridViewRow i in dataGridView1.Rows)
            {
                s.Add(i.Cells["MSSV"].Value.ToString());
            }
             dataGridView1.DataSource =  db.Sort(s, comboBox_Sort.Text, comboBox_direct.Text);
        }
    }
}
