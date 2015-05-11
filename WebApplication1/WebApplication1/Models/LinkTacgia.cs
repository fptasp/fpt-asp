using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    public class LinkTacgia
    {
        public string MaTG { get; set; }
        public virtual Sach Sach { get; set; }
        public virtual Tacgia Tacgia { get; set; }
    }
}