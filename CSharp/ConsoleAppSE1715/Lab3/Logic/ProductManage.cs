using Lab3.Models;

namespace Lab3.Logic
{
    public class ProductManage
    {
        public static List<Product> GetProductByCategoryId(int categoryId, int startIndx, int pageSize)
        {
            using(var context = new NorthwindContext())
            {
                if (categoryId == 0)
                {
                    return context.Products.Skip(startIndx).Take(pageSize).ToList();
                }
                else
                {
                    return context.Products.Where(x => x.CategoryId == categoryId).Skip(startIndx).Take(pageSize).ToList();
                }
            }
        }

        public static int NumberPage(int categoryId)
        {
            using(var context = new NorthwindContext())
            {
                if(categoryId == 0)
                {
                    return context.Products.ToList().Count;
                }
                else
                {
                    return context.Products.Where(x => x.CategoryId == categoryId).ToList().Count;
                }
            }
        }

        public static Product GetProductById(int id)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Where(x => x.ProductId == id).FirstOrDefault();
            }        
        }
        



    }
}
