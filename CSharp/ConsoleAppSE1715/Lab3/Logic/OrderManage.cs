using Lab3.Models;

namespace Lab3.Logic
{
    public class OrderManage
    {
        public static void AddOrder(Order order, List<ShoppingCartItem> cart)
        {
            using(var context = new NorthwindContext())
            {

                context.Orders.Add(order);
                context.SaveChanges();
                Console.WriteLine("New order Id: " + order.OrderId);
                order = context.Orders.OrderByDescending(x => x.OrderId).FirstOrDefault();
                foreach (ShoppingCartItem c in cart)
                {
                    OrderDetail o = new OrderDetail();
                    o.OrderId = order.OrderId;
                    o.ProductId = c.ProductId;
                    o.Quantity = (short)c.Quantity;
                    o.UnitPrice = (decimal)c.UnitPrice;
                    o.Discount = (short)c.Discount;
                    context.OrderDetails.Add(o);
                }
                context.SaveChanges();
            }
        }

    }
}
