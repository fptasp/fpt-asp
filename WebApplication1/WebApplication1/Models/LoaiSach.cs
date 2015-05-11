using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoaiSach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaLoai { get; set; }
        public string Tenloai { get; set; }
        public virtual ICollection<LinkLoaiSach> LinkLoaiSachs { get; set; }
    }
    public class LoaiSachDBContext : DbContext
    {
        public DbSet<LoaiSach> LoaiSachs { get; set; }
    }
}