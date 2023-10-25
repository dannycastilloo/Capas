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
        public List<Product> Get()
        {
            DProduct data = new DProduct();
            return data.Get();
        }
    }
}
