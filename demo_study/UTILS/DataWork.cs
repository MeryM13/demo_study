using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using demo_study.CLASSES;


namespace demo_study.UTILS
{
    public class DataWork
    {
        private static string connStr = ConnectionString.connectionString;

        public static User GetUserByLoginAndPassword(string login, string password)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "select * from [User] where UserLogin = @login and UserPassword = @password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("login", login);
                cmd.Parameters.AddWithValue("password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    user.Role = reader.GetInt32(1);
                    user.Name = reader.GetString(2);
                    user.Login = login;
                    user.Password = password;
                    return user;
                }

                throw new DataException("Пользователь не найден. Проверьте правильность введенных данных");
            }
        }

        public static List<Product> GetProductList(string search, bool sortUp, string manufacturer)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "select * from Product";
                if (!String.IsNullOrEmpty(search))
                {
                    sql += $" where ProductName like '%{search}%'" +
                           $" or ProductDescription like '%{search}%'" +
                           $" or ProductManufacturer like '%{search}%'";
                }
                if (!String.IsNullOrEmpty(manufacturer))
                {
                    sql += string.IsNullOrEmpty(search) ? " where" : " and";
                    sql += $" ProductManufacturer = '{manufacturer}'";
                }
                sql += " order by ProductCost" + (sortUp? " asc": " desc");
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<Product> list = new List<Product>();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Article = reader.GetString(0);
                    product.Name = reader.GetString(1);
                    product.Unit = reader.GetString(2);
                    product.Cost = reader.GetDecimal(3);
                    try
                    {
                        product.DiscountAmount = reader.GetInt32(4);
                    }
                    catch{ }
                    product.Manufacturer = reader.GetString(5);
                    product.Supplier = reader.GetString(6);
                    product.Category = reader.GetString(7);
                    product.CurrentDiscount = reader.GetInt32(8);
                    product.Quantity = reader.GetInt32(9);
                    product.Description = reader.GetString(10);
                    try
                    {
                        product.Photo = reader.GetString(11);
                    }
                    catch { }
                    list.Add(product);
                }
                return list;
            }
        }

        public static List<String> GetManufacturerList()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "select distinct ProductManufacturer from Product";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                return list;
            }
        }

        public static int GetProductListCount(string search, string manufacturer)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "select count(*) from Product";
                if (!String.IsNullOrEmpty(search))
                {
                    sql += $" where ProductName like '%{search}%'" +
                           $" or ProductDescription like '%{search}%'" +
                           $" or ProductManufacturer like '%{search}%'";
                }
                if (!String.IsNullOrEmpty(manufacturer))
                {
                    sql += string.IsNullOrEmpty(search) ? " where" : " and";
                    sql += $" ProductManufacturer = '{manufacturer}'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return reader.GetInt32(0);
                }

                throw new DataException("");
            }
        }
    }
}
