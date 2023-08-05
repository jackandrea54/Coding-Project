namespace Lab3.Models
{
    public class ShoppingCartItem:OrderDetail
    {
        public int ProductId { get; set; }  
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get;set; }
        public double TotalMoney { get;set; }
        public double Discount { get; set; } = 0.1;
    }
}
