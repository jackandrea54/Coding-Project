using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADOModel.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } 
        public float UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Product()
        {
        }

        public Product(int productID, string productName, float unitPrice, int categoryID, string categoryName)
        {
            ProductID = productID;
            ProductName = productName;
            UnitPrice = unitPrice;
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
    }
}
