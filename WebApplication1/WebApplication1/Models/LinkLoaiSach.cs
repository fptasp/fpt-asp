using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Controllers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class LinkLoaiSach
    {
        [Key]
        public int MaLoai { get; set; }
        public virtual Sach Sach { get; set; }
        public virtual LoaiSach LoaiSach { get; set; }
    }
}