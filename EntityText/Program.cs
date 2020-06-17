using EntityText.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityText
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new QuanLySinhVienDBContext())
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}
