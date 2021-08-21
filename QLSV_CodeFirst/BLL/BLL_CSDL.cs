using QLSV_CodeFirst.DAL;
using QLSV_CodeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_CodeFirst.BLL
{
    public class BLL_CSDL
    {
        private static BLL_CSDL _Instance;
        public static BLL_CSDL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_CSDL();
                return _Instance;
            }
            private set { }
        }
        public List<SV> GetAllSV_BLL()
        {
            return DAL_CSDL.Instance.GetAllSV_DAL();
        }
        public List<SV> GetListSV_BLL(int ID_Lop, string Name)
        {
            if (Name == "")
            {
                if (ID_Lop == 0)
                {
                    return DAL_CSDL.Instance.GetAllSV_DAL();
                }
                else
                {
                    List<SV> a = new List<SV>();
                    foreach (SV i in DAL_CSDL.Instance.GetAllSV_DAL())
                    {
                        if (i.ID_Lop == ID_Lop) a.Add(i);
                    }
                    return a;
                }
            }
            else
            {
                List<SV> a = new List<SV>();
                foreach (SV i in DAL_CSDL.Instance.GetAllSV_DAL())
                {
                    if ((ID_Lop == 0 || i.ID_Lop == ID_Lop) && i.NameSV == Name) a.Add(i);
                }
                return a;
            }
        }
        public List<SV_GUI> GetListSV_GUI_BLL(int ID_Lop,string Name)
        {
            List<SV_GUI> l = new List<SV_GUI>();
            foreach (SV i in GetListSV_BLL(ID_Lop, Name))
            {
                l.Add(new SV_GUI { Ten_Sinh_Vien = i.NameSV, Gioi_Tinh = i.Gender, Ngay_Sinh = i.NS, Lop_Hoc_Phan = Get_Name_LopSV(i.ID_Lop) });
            }
            return l;
        }
        private string Get_Name_LopSV(int i)
        {
            foreach (LSH l in GetAllLSH_BLL())
            {
                if (l.ID == i) return l.NameLop;
            }
            return "";
        }
        public SV GetSVbyMSSV(string mssv)
        {
            foreach(var a in GetAllSV_BLL())
            {
                if (a.MSSV == mssv) return a;
            }
            return new SV();
        }
        public List<LSH> GetAllLSH_BLL()
        {
            return DAL_CSDL.Instance.GetAllLSH_DAL();
        }
        private int GetID_Lop(string str)
        {
            foreach (LSH l in GetAllLSH_BLL())
            {
                if (l.NameLop == str) return l.ID;
            }
            return 0;
        }
        private bool Check_MSSV(string MSSV)
        {
            foreach (SV a in GetAllSV_BLL())
            {
                if (a.MSSV == MSSV) return false;
            }
            return true;
        }
        public bool Execute_AddorEDit_BLL(string m, SV a)
        {
            //execute add or edit
            if (m == "")
            {
                if (Check_MSSV(a.MSSV))
                {
                    DAL_CSDL.Instance.AddSV_DAL(a);
                    return true;
                }
                else return false;
            }
            else
            {
                DAL_CSDL.Instance.EditSV_DAL(a);
            }
            return true;
        }
        public string GetMSSV(DataGridViewRow r)
        {
            Console.WriteLine(r.ToString());
            foreach (SV i in DAL_CSDL.Instance.GetAllSV_DAL())
            {
                if ((r.Cells["Ten_Sinh_Vien"].Value).ToString() == i.NameSV 
                    && Convert.ToBoolean(r.Cells["Gioi_Tinh"].Value) == i.Gender
                    && Convert.ToDateTime(r.Cells["Ngay_Sinh"].Value) == i.NS
                    && GetID_Lop((r.Cells["Lop_Hoc_Phan"].Value).ToString()) == i.ID_Lop) 
                    return i.MSSV;
            }

            return "";
        }
        public void DeleteRow_BLL(DataGridViewRow row)
        {
            string MSSV = GetMSSV(row);
            DAL_CSDL.Instance.DeleteRow_DAL(MSSV);
        }
        public List<SV_GUI> Sort(int ID,int ID_Lop, string name)
        {
            List<SV_GUI> l = new List<SV_GUI>();
            l = GetListSV_GUI_BLL(ID_Lop, name);
            switch (ID)
            {
                case 0:
                    l.Sort(new Compare_Ten_Sinh_Vien());
                    break;
                case 1:
                    l.Sort(new Compare_Gioi_Tinh());
                    break;
                case 2:
                    l.Sort(new Compare_Ngay_Sinh());
                    break;
                case 3:
                    l.Sort(new Compare_Lop_Hoc_Phan());
                    break;
            }
            return l;
        }
        class Compare_Ten_Sinh_Vien : IComparer<SV_GUI>
        {
            public int Compare(SV_GUI x,SV_GUI y)
            {
                return String.Compare(x.Ten_Sinh_Vien, y.Ten_Sinh_Vien);
            }
        }
        class Compare_Gioi_Tinh : IComparer<SV_GUI>
        {
            public int Compare(SV_GUI x, SV_GUI y)
            {
                return String.Compare(x.Gioi_Tinh.ToString(), y.Gioi_Tinh.ToString());
            }
        }
        class Compare_Ngay_Sinh : IComparer<SV_GUI>
        {
            public int Compare(SV_GUI x, SV_GUI y)
            {
                if (x.Ngay_Sinh == y.Ngay_Sinh) return 0;
                return (x.Ngay_Sinh > y.Ngay_Sinh) ? 1 : -1;
            }
        }
        class Compare_Lop_Hoc_Phan : IComparer<SV_GUI>
        {
            public int Compare(SV_GUI x, SV_GUI y)
            {
                return String.Compare(x.Lop_Hoc_Phan, y.Lop_Hoc_Phan);
            }
        }
    }
}
