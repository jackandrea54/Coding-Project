using System.Collections.Generic;
using System.Linq;
using LAB3Northwind.Models;

namespace LAB3Northwind.Logics
{
    public class ProductLogic
    {
        public static readonly NorthwindContext _context = new NorthwindContext();

        // get all products by category id
        public static List<Product> GetAllProductsByCategoryId(int categoryId, int offset, int limit)
        {
            if (categoryId == 0)
            {
                return _context.Products.Skip(offset - 1).Take(limit).ToList();
            }
            else
            {
                return _context.Products.Where(m => m.CategoryId == categoryId).Skip(offset - 1).Take(limit).ToList();
            }
        }
        // get product by id
        public static Product GetProductById(int id)
        {
            return _context.Products.Where(m => m.ProductId == id).FirstOrDefault();
        }
    }
}
