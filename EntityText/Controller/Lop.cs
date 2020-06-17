using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityText.Controller
{
    public class Lop
    {
        [Key]
        public string MaLop { get; set; }
        [Required]
        public string TenLop { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }


    }
}
