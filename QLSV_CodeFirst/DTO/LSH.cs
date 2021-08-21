using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_CodeFirst.DTO
{
    [Table("LopSinhHoat")]
    public class LSH
    {
        [Key]
        public int ID { get; set; }
        public string NameLop { get; set; }
        public virtual ICollection<SV> SVs { get; set; }
        public LSH()
        {
            SVs = new HashSet<SV>();
        }
    }
}
