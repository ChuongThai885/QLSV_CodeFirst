using QLSV_CodeFirst.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace QLSV_CodeFirst.DTO
{
    public class CSDL : DbContext
    {
        private static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL();
                return _Instance;
            }
            private set { }
        }
        public CSDL()
            : base("name=CSDL")
        {
            Database.SetInitializer<CSDL>(new CreateDB());
        }
        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<LSH> LSHes { get; set; }
    }
}