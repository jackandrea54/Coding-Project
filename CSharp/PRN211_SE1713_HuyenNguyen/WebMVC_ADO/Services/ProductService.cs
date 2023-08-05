using System.Data;
using WebMVC_ADO.Models;

namespace WebMVC_ADO.Services
{
    public class ProductService
    {
        static DataProvider d = new DataProvider();

        public ProductService() { }
        public static List<Product> getAllProducts()
        {
            List<Product> data = new List<Product>();

            // danh sach Product
            string strSelect = "SELECT * FROM Products";
            using (IDataReader dr = d.executeQuery2(strSelect))
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    decimal price = dr.GetDecimal(2);
                    int stock = dr.GetInt32(3);
                    string image = dr.GetString(4);
                    int categoryId = dr.GetInt32(5);
                    Product p = new Product();
                    p.ProductId = id;
                    p.ProductName = name;
                    p.UnitPrice = price;
                    p.UnitsInStock = stock;
                    p.Image = image;
                    p.CategoryId = categoryId;
                    data.Add(p);
                }
            }
            return data;
        }
    }
}
