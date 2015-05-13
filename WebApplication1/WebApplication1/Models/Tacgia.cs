using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Controllers
{
    public class Tacgia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int MaTG { get; set; }
        public string Tentacgia { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public virtual ICollection<LinkTacgia> Enrollments { get; set; }
    }
}