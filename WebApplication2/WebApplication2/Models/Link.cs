using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Link
    {
        [Key]
        public int ProductID { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}