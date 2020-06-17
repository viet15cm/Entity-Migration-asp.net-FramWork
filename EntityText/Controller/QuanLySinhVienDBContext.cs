using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityText.Controller
{
    public class QuanLySinhVienDBContext : DbContext
    {
        public QuanLySinhVienDBContext() : base("name=QLSV")
        {
        }

        DbSet<Lop> Lops { get; set; }
        DbSet<SinhVien> sinhViens { get; set; }
    }
}
