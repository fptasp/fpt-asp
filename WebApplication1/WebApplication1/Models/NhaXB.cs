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
    public class NhaXB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public virtual ICollection<LinkNhaXB> Enrollments { get; set; }
    }
}