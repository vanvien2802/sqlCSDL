using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BaiTap22032022
{
    class QLSV
    {
        public delegate bool  Mydel(Sv s1,Sv s2);
        public List<Sv> GetAllSv()
        {
            List<Sv> data = new List<Sv>();
            foreach(DataRow i in DataSv.Instance.data.Rows)
            {
                data.Add(Convert_DataRow_To_Sv(i));
            }
            return data;
        }
        public Sv Convert_DataRow_To_Sv(DataRow i)
        {
            return new Sv
            {
                Name = i["Name"].ToString(),
                MSSV = i["MSSV"].ToString(),
                Class = i["Class"].ToString(),
                Gender = Convert.ToBoolean( i["Gender"].ToString()),
                DateOfBirth  = Convert.ToDateTime(i["DateOfBirth"].ToString()),
                GPA = (float)Convert.ToDouble(i["GPA"].ToString()),
                Anh = Convert.ToBoolean(i["Anh"].ToString()),
                Hoc_Ba = Convert.ToBoolean(i["HocBa"].ToString()),
                CCNN = Convert.ToBoolean(i["CCNN"].ToString())



            };
        }
        public List<Sv> Search(string lop, string txt)
        {
            List<Sv> data = new List<Sv>();
            if (lop == "All")
            {
                
                foreach(Sv i in GetAllSv())
                {
                  if(i.Name.Contains(txt))
                    {
                        data.Add(i);
                    }
                }
            }
            else
            foreach(Sv i in GetAllSv())
            {
                if(i.Class==lop&&i.Name.Contains(txt))
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public List<string> Get_Class()
        {
            List<string> data = new List<string>();
            foreach(Sv i in GetAllSv())
            {
                data.Add(i.Class);
            }
            return data;
        }
        public void UpdateAdd(Sv s)
        {
            bool add = true;
            foreach(Sv i in GetAllSv())
            {
                if(i.MSSV==s.MSSV)
                {
                    add = false;
                    break;
                }
            }
            if (add)
            {
                Add(s);
                
            }
            else Update(s);
        }
        private void Add(Sv s)
        {
            DataSv.Instance.AddDataSV(s);
        }
        private void Update(Sv s)
        {
            DataSv.Instance.UpDate(s);
        }
        public void Del(List<Sv> s)
        {
            foreach (Sv i in s)
            {
                DataSv.Instance.DelDataSV(i);
            }
        }
        public Sv GetSvByMssv(string s)
        {
            foreach (Sv j in GetAllSv())
            {
                if(s==j.MSSV)
                return j;
            }
            return null;
        }
        public List<Sv> ConvertListStringToListSv(List<string> now )
        {
            List<Sv> data = new List<Sv>();
            foreach(string i in now)
            {
                foreach(Sv j in GetAllSv())
                {
                    if (j.MSSV == i)
                        data.Add(j);
                }
            }
            return data;
        }
        private bool Name_ASC(Sv s1, Sv s2)
        {
            if (string.Compare(s1.Name,s2.Name)<0) return true;
            else return false;
        }
        private bool Name_DESC(Sv s1, Sv s2)
        {
            if (string.Compare(s1.Name, s2.Name) > 0) return true;
            else return false;
        }
        private bool MSSV_ASC(Sv s1, Sv s2)
        {
            if (string.Compare(s1.MSSV, s2.MSSV) < 0) return true;
            else return false;
        }
        private bool MSSV_DESC(Sv s1, Sv s2)
        {
            if (string.Compare(s1.MSSV, s2.MSSV) > 0) return true;
            else return false;
        }
        private void Swap(List<Sv> list, int  i,  int   j )
        {
            Sv temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
       
        public List<Sv> Sort(List<string> s, string s1 , string s2)
        {
            Mydel d;
            if (s1 == "Ten")
            {
                if (s2 == "Tang")
                    d = Name_ASC;
                else d = Name_DESC;
            }
            else
            {
                if (s2 == "Tang")
                    d = MSSV_ASC;
                else d = MSSV_DESC;
            }
            List<Sv> now = new List<Sv>();
            now = ConvertListStringToListSv(s);
            for(int i=0;i<now.Count-1;i++)
            {
                for(int j=i+1;j<now.Count;j++)
                {
                    Swap(now, i, j);
                }
            }
            return now;
        }
    }
}
