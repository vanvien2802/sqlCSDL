using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BaiTap22032022
{
    public partial class DetailForm : Form
    {
        public delegate void MyDel(string s, string txt);
        public MyDel d;
        private QLSV bbl = new QLSV();
        public string MSSV { get; set; }
        public DetailForm(string m)
        {
            InitializeComponent();
            MSSV = m;
            foreach (string i in bbl.Get_Class().Distinct())
            {
                comboBox_lsh.Items.Add(i);
            }
            GUI();
        }
        void GUI()
        {
            if(MSSV!="")
            {
                Sv s = bbl.GetSvByMssv(MSSV);
                textBox_Mssv.Enabled = false;
                textBox_Mssv.Text = s.MSSV;
                textBox_Name.Text = s.Name;
                textBox_gpa.Text = Convert.ToString(s.GPA);
                comboBox_lsh.SelectedItem = s.Class;
                if (s.Gender) radioButton_male.Checked = true;
                else radioButton_Female.Checked = true;
                dateTimePicker_ns.Value = s.DateOfBirth;
                checkBox_anh.Checked = s.Anh;
                checkBox_ccnn.Checked = s.CCNN;
                checkBox_HocBa.Checked = s.Hoc_Ba;
           
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Sv s = new Sv
            {
                Name = textBox_Name.Text,
                MSSV = textBox_Mssv.Text,
                Class = comboBox_lsh.SelectedItem.ToString(),
                Gender = (radioButton_Female.Checked == true ? radioButton_Female.Checked : radioButton_male.Checked),
                DateOfBirth = dateTimePicker_ns.Value,
                GPA = (float)Convert.ToDouble(textBox_gpa.Text),
                Anh = checkBox_anh.Checked,
                Hoc_Ba = checkBox_HocBa.Checked,
                CCNN = checkBox_ccnn.Checked
            };
            bbl.UpdateAdd(s);
            d("All", "");
            this.Dispose();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
