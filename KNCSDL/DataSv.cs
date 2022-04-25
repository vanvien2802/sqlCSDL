using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap22032022
{
    public class DataSv
    {

        private static DataSv _Instance;
        public DataTable data
        {
            get;
        }
        public static DataSv Instance
        {
            get
            {
                if(_Instance==null)
                {
                    _Instance = new DataSv();
                }
                return _Instance;
            }
        }

            private DataSv()
        {
            data = new DataTable( );
            data.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn { DataType =typeof(string) , ColumnName = "MSSV"},
                new DataColumn { DataType =typeof(string) , ColumnName = "Name"},
                new DataColumn { DataType =typeof(string) , ColumnName = "Class"},
                new DataColumn { DataType =typeof(bool) , ColumnName = "Gender"},
                new DataColumn { DataType =typeof(DateTime) , ColumnName = "DateOfBirth"},
                new DataColumn { DataType =typeof(float) , ColumnName = "GPA"},
                new DataColumn { DataType =typeof(bool) , ColumnName = "Anh"},
                new DataColumn { DataType =typeof(bool) , ColumnName = "HocBa"},
                new DataColumn { DataType =typeof(bool) , ColumnName = "CCNN"}
                });

            data.Rows.Add(
                 102200998, "Pham Van Tien Truong", "20TClC_DT4" ,true, new DateTime(2002, 11, 18), 3.4, 
                  true,  false, true 
                );
            data.Rows.Add(
                 102200999, "Pham Cong Huy", "20TClC_DT5", false, new DateTime(2002, 11, 18), 3.4, 
                 true, true,  true 
                );
            data.Rows.Add(
                 102200200, "Tran Van Hai", "20TClC_DT3", true, new DateTime(2002, 11, 18), 3.4, 
               true,  false,  true
                );
            data.Rows.Add(
                 102200201, "Nguyen Hoang Vu", "20TClC_DT2", false, new DateTime(2002, 11, 18), 3.4, 
                true, true,  true 
                );
            data.Rows.Add(
                 102200202, "Nguyen Hoang Phong ", "20TClC_DT1", true, new DateTime(2002, 11, 18), 3.4, 
                 true,  false, true 
                );

        }
        public void AddDataSV( Sv s)
        {
            data.Rows.Add(
                 s.MSSV, s.Name, s.Class,s.Gender, s.DateOfBirth, s.GPA,
                  s.Anh, s.Hoc_Ba, s.CCNN
                );
        }
        public void DelDataSV(Sv s)
        {
            foreach(DataRow i in data.Rows)
            {
               if(i["MSSV"].ToString()==s.MSSV)
                {
                    data.Rows.Remove(i);
                    break;
                }
            }
        }
        public void UpDate(Sv s)
        {
            foreach (DataRow i in data.Rows)
            {
                if (i["MSSV"].ToString() == s.MSSV)
                {
                    i["Name"] = s.Name;
                    i["MSSV"] = s.MSSV;
                    i["Class"] = s.Class;
                    i["Gender"] = s.Gender;
                    i["DateOfBirth"] = s.DateOfBirth;
                    i["GPA"] = s.GPA;
                    i["Anh"] = s.Anh;
                    i["HocBa"] = s.Hoc_Ba;
                    i["CCNN"] = s.CCNN;
                }
            }
        }
    }
   
    
}
