using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    public class LinkLoaiSach
    {
        public string MaLoai { get; set; }
        public virtual Sach Sach { get; set; }
        public virtual LoaiSach LoaiSach { get; set; }
    }
}