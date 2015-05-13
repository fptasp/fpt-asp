using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Controllers
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }
        public int MaLoai { get; set; }
        public string Tensach { get; set; }
        public string Tomtat { get; set; }
        public int MaTG { get; set; }
        public int MaNXB { get; set; }
        public virtual ICollection<LinkLoaiSach> LinkLoaiSachs { get; set; }
        public virtual ICollection<LinkTacgia> LinkTacgias { get; set; }
        public virtual ICollection<LinkNhaXB> LinkNhaXBs { get; set; }
    }
    public class SachDBContext : DbContext
    {
        public DbSet<Sach> Sachs { get; set; }
    }
}