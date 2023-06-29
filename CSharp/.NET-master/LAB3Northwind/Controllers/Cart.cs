using LAB3Northwind.Models;

namespace LAB3Northwind.Controllers
{
    public class Cart
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Cart(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public decimal? TotalPrice()
        {
            return Product.UnitPrice * Quantity;
        }
    }
}
