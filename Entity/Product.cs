using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool Active { get; set; }
    }
}