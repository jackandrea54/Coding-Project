using Microsoft.AspNetCore.Mvc;
using LAB3Northwind.Models;
using LAB3Northwind.Logics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
namespace LAB3Northwind.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ViewCart()
        {
            var session = HttpContext.Session;
            List<Cart> carts = new List<Cart>();
            if (session.GetString("Carts") != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Carts"));
            }
            return View("View", carts);
        }
        public IActionResult AddToCart(int productId)
        {
            var session = HttpContext.Session;
            Product product = ProductLogic.GetProductById(productId);
            if (product != null && product.UnitsInStock > 0)
            {
                if (session.Get("Carts") == null)
                {
                    Cart cart = new Cart(product, 1);
                    List<Cart> carts = new List<Cart>();
                    carts.Add(cart);
                    // serialize cart to json string
                    string json = JsonConvert.SerializeObject(carts);
                    session.SetString("Carts", json);
                }
                else
                {
                    // get cart from session hash table
                    List<Cart> carts = JsonConvert.DeserializeObject<List<Cart>>(session.GetString("Carts"));
                    // check if product is already in cart
                    bool isExist = false;
                    foreach (Cart cart in carts)
                    {
                        if (cart.Product.ProductId == productId)
                        {
                            if (cart.Quantity < cart.Product.UnitsInStock)
                            {
                                cart.Quantity++;
                            }
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        Cart cart = new Cart(product, 1);
                        carts.Add(cart);
                    }
                    string json = JsonConvert.SerializeObject(carts);
                    session.SetString("Carts", json);
                }
            }
            // store product in session hash table


            return Redirect(HttpContext.Request.Headers["Referer"].ToString());
            //return RedirectToAction("List", "Product");
        }
    }
}
