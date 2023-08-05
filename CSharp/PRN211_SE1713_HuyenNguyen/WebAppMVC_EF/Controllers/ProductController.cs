using Microsoft.AspNetCore.Mvc;
using WebAppMVC_EF.Models;

namespace WebAppMVC_EF.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {

                // danh sach category
                ViewBag.categories = context.Categories.ToList();

                // danh sach product
                var products = context.Products.ToList();


                return View(products);
            }

        }

        [HttpPost]
        public IActionResult Index(int categoryId)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {

                // danh sach category
                ViewBag.categories = context.Categories.ToList();

                // danh sach product
                List<Product> products = categoryId == 0 ? context.Products.ToList()
                    : context.Products.Where(p => p.CategoryId == categoryId).ToList();

                // truyen lai categoryId cho view
                ViewBag.selectedId = categoryId;

                return View(products);
            }


        }
        public IActionResult Add()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                // danh sach category
                ViewBag.categories = context.Categories.ToList();
                return View();
            }
        }

        [HttpPost]
        public IActionResult Add(Product p)
        {
            if (ModelState.IsValid)
            {
                using (MySaleDBContext context = new MySaleDBContext())
                {
                    context.Add(p);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Add");
            }
        }


        public IActionResult Delete(int id)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                // tim doi tuong can xoa
                Product product = context.Products.SingleOrDefault(p => p.ProductId == id);
                context.Products.Remove(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult Update(int id)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                // tim doi tuong can update
                ViewBag.categories = context.Categories.ToList();

                Product product = context.Products.SingleOrDefault(p => p.ProductId == id);
                return View(product);
            }
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {

                // tim doi tuong can update
                Product productToUpdate = context.Products
                    .SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.Image = product.Image;
                productToUpdate.CategoryId = product.CategoryId;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
