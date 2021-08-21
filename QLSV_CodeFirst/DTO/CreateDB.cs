using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QLSV_CodeFirst.DTO
{
    class CreateDB 
        : DropCreateDatabaseIfModelChanges<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.LSHes.AddRange(new LSH[]
            {
                new LSH{ID = 1,NameLop = "19TCLCDT1"},
                new LSH{ID = 2,NameLop = "19TCLCDT2"},
                new LSH{ID = 3,NameLop = "19TCLCDT3"},
                new LSH{ID = 4,NameLop = "19TCLCDT4"}
            });
            context.SVs.AddRange(new SV[]
            {
                new SV{MSSV = "2",NameSV = "NVA",Gender = true,NS = Convert.ToDateTime("7-15-2001"),ID_Lop =1},
                new SV{MSSV = "4",NameSV = "NVB",Gender = true,NS = Convert.ToDateTime("6-1-2001"),ID_Lop =2},
                new SV{MSSV = "5",NameSV = "NTC",Gender = false,NS = Convert.ToDateTime("12-12-2001"),ID_Lop =3},
                new SV{MSSV = "1",NameSV = "NVD",Gender = true,NS = Convert.ToDateTime("1-1-2001"),ID_Lop =4},
            });
        }
    }
}
