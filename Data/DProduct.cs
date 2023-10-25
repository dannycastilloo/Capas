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

        public static List<Product> ListCustomer()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "ListProducts";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine("Products List: ");
                            while (reader.Read())
                            {
                                products.Add(new Product()
                                {
                                    Name = (string)reader["name"],
                                    Price = (decimal)reader["price"],
                                    Stock = (int)reader["stock"],
                                    Active = (bool)reader["active"]
                                });
                            }
                        }
                    }
                }
                connection.Close();
            }
            return products;
        }
    }
}
