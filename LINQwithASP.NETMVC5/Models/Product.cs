using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LINQwithASP.NETMVC5.Models
{
    public class Product
    {
        [Key]
       public int Id { get; set; }
        public string Name { get; set; }
        public string Qty { get; set; }
        public string Price { get; set; }
        public DateTime EntryDate { get; set; }
    }
}