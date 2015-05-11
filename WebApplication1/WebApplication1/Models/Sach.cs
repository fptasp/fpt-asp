using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string MaLoai { get; set; }
        public string Tensach { get; set; }
        public string Tomtat { get; set; }
        public string MaTG { get; set; }
        public string MaNXB { get; set; }
        public virtual ICollection<LinkLoaiSach> LinkLoaiSachs { get; set; }
        public virtual ICollection<LinkTacgia> LinkTacgias { get; set; }
        public virtual ICollection<LinkNhaXB> LinkNhaXBs { get; set; }
    }
    public class SachDBContext : DbContext
    {
        public DbSet<Sach> Sachs { get; set; }
    }
}