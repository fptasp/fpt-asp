using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace WebApplication1.Controllers
{
    public class NhaXB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    public class NhaXBDBContext : DbContext
    {
        public DbSet<NhaXB> NhaXBs { get; set; }
    }
}