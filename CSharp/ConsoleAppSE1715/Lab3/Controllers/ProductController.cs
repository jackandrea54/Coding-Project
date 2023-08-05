using System.Collections.Generic;
using Lab3.Logic;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id, int page)
        {
            if (page == 0) page = 1;
            var pageSize = 5;
            ViewBag.categories = CategoryManage.GetAllCategories();
            List<Product> products = ProductManage.GetProductByCategoryId(id, (page-1)*pageSize, pageSize);
            int totalProducts = ProductManage.NumberPage(id);
            int numberPage = (int)totalProducts/pageSize;
            if (totalProducts % pageSize != 0) numberPage += 1;
            ViewData["numberPage"] = numberPage;
            ViewData["currPage"] = page;
            ViewData["CateId"] = id;
            var context = new NorthwindContext();
            ViewData["order"] = context.Orders.ToList();
            return View(products);
        }   
    }
}
