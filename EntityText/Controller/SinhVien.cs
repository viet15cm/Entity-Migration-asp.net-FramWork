using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityText.Controller
{
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        [Required]
        public string TenSV { get; set; }
        public string Lop { get; set; }

    }
}
