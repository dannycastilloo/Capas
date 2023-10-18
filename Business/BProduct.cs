using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;
using System.Data.SqlClient;

namespace Business
{
    public class BProduct
    {
        private DProduct data;
        public BProduct()
        {
            data = new DProduct();
        }

        public List<Product> GetByName(string Name)
        {
            List<Product> result = new List<Product>();

            // Obtengo todos los productos
            var products = data.Get();

            // Filtro por nombre
            foreach (var item in products)
            {
                if (item.Name == Name)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
