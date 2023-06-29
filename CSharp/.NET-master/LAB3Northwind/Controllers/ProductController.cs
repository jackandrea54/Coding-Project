using System.Collections.Generic;
using System.Linq;
using LAB3Northwind.Helper;
using LAB3Northwind.Logics;
using LAB3Northwind.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LAB3Northwind.Controllers
{
    public class ProductController : Controller
    {
        public static readonly NorthwindContext _context = new NorthwindContext();
        public int ITEMS_PER_PAGE = 12;
        [BindProperty(SupportsGet = true, Name = "page")]
        public int CurrentPage { get; set; }
        public int CountPages { get; set; }
        public IActionResult List(int categoryId)
        {
            var session = HttpContext.Session;
            int _totalItems = 0;
            if (session.Get("Carts") != null)
            {
                List<Cart> carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Carts"));
                _totalItems = carts.Count;
            }
            if (categoryId == 0)
            {
                int _totalProduct = _context.Products.Count();
                CountPages = (int)_totalProduct / ITEMS_PER_PAGE;
                if (_totalProduct % ITEMS_PER_PAGE != 0)
                {
                    CountPages = CountPages + 1;
                }
            }
            if (categoryId != 0)
            {
                int _totalProduct = _context.Products.Where(x => x.CategoryId == categoryId).Count();
                CountPages = (int)_totalProduct / ITEMS_PER_PAGE;
                if (_totalProduct % ITEMS_PER_PAGE != 0)
                {
                    CountPages = CountPages + 1;
                }
            }
            if (CurrentPage < 1)
            {
                CurrentPage = 1;
            }
            if (CurrentPage > CountPages)
            {
                CurrentPage = CountPages;
            }
            ViewData["totalItems"] = _totalItems;
            ViewData["View"] = ITEMS_PER_PAGE;
            PagingHelper pagingHelper = new PagingHelper();
            pagingHelper.CurrentPage = CurrentPage;
            pagingHelper.CountPage = CountPages;
            ViewData["categoryId"] = categoryId;
            ViewData["Paging"] = pagingHelper;
            List<Category> categories = CategoryLogic.GetAllCategories();
            List<Product> products = ProductLogic.GetAllProductsByCategoryId(categoryId, (CurrentPage - 1) * ITEMS_PER_PAGE + 1, ITEMS_PER_PAGE);
            ViewData["Categories"] = categories;
            return View(products);
        }
    }
}
