using System;
using System.Collections.Generic;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class Product
    {
        public Product()
        {
            Favourites = new HashSet<Favourite>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductsSpecifiedAttributes = new HashSet<ProductsSpecifiedAttribute>();
            Sliders = new HashSet<Slider>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PreviewImage { get; set; }
        public short? Insurance { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal? InitialPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductStatus Status { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
        public virtual ICollection<Favourite> Favourites { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductsSpecifiedAttribute> ProductsSpecifiedAttributes { get; set; }
        public virtual ICollection<Slider> Sliders { get; set; }
    }
}
