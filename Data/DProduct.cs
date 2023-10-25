using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Entity;

namespace Data
{
    public class DProduct
    {
        public static string connectionString = "Data Source=LAB1504-08\\SQLEXPRESS; Initial Catalog=Lab08; User ID=Danny; Password=123456";

        public List<Product> Get()
        {
            var result = new List<Product>
            {
                new Product { ProductId = 4, Name = "Teclado", Price = 350, Stock = 10, Active = true },
                new Product { ProductId = 5, Name = "Teclado", Price = 350, Stock = 10, Active = true }
            };

            return result;

        }
    }
}
