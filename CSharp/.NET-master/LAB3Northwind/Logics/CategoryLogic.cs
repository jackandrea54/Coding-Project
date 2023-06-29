using System.Collections.Generic;
using System.Linq;
using LAB3Northwind.Models;

namespace LAB3Northwind.Logics
{
    public class CategoryLogic
    {
        public static readonly NorthwindContext _context = new NorthwindContext();
        // get all categories
        public static List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
