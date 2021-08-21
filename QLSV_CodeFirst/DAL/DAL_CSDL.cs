using QLSV_CodeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_CodeFirst.DAL
{
    class DAL_CSDL
    {
        private static DAL_CSDL _Instance;
        public static DAL_CSDL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_CSDL();
                return _Instance;
            }
            private set { }
        }
        public List<SV> GetAllSV_DAL()
        {
            return CSDL.Instance.SVs.ToList();
        }
        public List<LSH> GetAllLSH_DAL()
        {
            return CSDL.Instance.LSHes.ToList();
        }

        public void AddSV_DAL(SV a)
        {
            CSDL.Instance.SVs.Add(a);
            CSDL.Instance.SaveChanges();
        }

        public void EditSV_DAL(SV a)
        {
            SV i = CSDL.Instance.SVs.Find(a.MSSV);
            CSDL.Instance.SVs.Remove(i);
            AddSV_DAL(a);
        }
        public void DeleteRow_DAL(string MSSV)
        {
            SV a = new SV();
            foreach(var i in GetAllSV_DAL())
            {
                if (i.MSSV == MSSV) a = i;
            }
            CSDL.Instance.SVs.Remove(a);
            CSDL.Instance.SaveChanges();
        }
    }
}
