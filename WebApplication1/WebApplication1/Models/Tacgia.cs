using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public class Tacgia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaTG { get; set; }
        public string Tentacgia { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
    public class TacgiaDBContext : DbContext
    {
        public DbSet<Tacgia> Tacgia { get; set; }
    }
}