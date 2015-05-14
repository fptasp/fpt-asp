using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int count { get; set; }
        public long CountPrice { get; set; }
        public virtual ICollection<Link> Links { get; set; }
    }
}