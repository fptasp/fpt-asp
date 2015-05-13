using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using WebApplication1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Controllers
{
    public class LoaiSach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int MaLoai { get; set; }
        public string Tenloai { get; set; }
        public virtual ICollection<LinkLoaiSach> LinkLoaiSachs { get; set; }
    }
}