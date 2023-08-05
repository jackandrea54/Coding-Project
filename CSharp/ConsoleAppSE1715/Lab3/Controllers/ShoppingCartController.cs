using Lab3.Logic;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Cart()
        {
            List<ShoppingCartItem> carts = HttpContext.Session.Get<List<ShoppingCartItem>>("cart") ?? new List<ShoppingCartItem>();
            return View(carts);
        }


        [HttpPost]
        public IActionResult AddToCart(int id, int number) 
        {
            List<ShoppingCartItem> carts = HttpContext.Session.Get<List<ShoppingCartItem>>("cart") ?? new List<ShoppingCartItem>();
            Product product = ProductManage.GetProductById(id);
            ShoppingCartItem item = carts.Where(x => x.ProductId == id).FirstOrDefault();
            if(item != null && item.ProductId == id)
            {
                item.Quantity += number;
            }
            else
            {
                ShoppingCartItem p = new ShoppingCartItem();
                p.ProductId = product.ProductId;
                p.Quantity = number;
                p.UnitPrice = (double)product.UnitPrice;
                p.ProductName = product.ProductName;
                carts.Add(p);
            }
            HttpContext.Session.Set<List<ShoppingCartItem>>("cart", carts);
            return RedirectToAction("Cart");
        }


        public IActionResult Checkout()
        {
            List<ShoppingCartItem> carts = HttpContext.Session.Get<List<ShoppingCartItem>>("cart") ?? new List<ShoppingCartItem>();
            OrderManage.AddOrder(new Order(), carts);
            HttpContext.Session.Remove("cart");
            return Redirect("Cart");
        }
    }
}
