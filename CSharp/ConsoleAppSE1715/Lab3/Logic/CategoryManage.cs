using Lab3.Models;

namespace Lab3.Logic
{
    public class CategoryManage
    {
        public static List<Category> GetAllCategories() 
        {
            using(var context = new NorthwindContext())
            {
                return context.Categories.ToList(); 
            }
        }


    }
}
