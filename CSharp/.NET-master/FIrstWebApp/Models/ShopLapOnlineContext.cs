using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FIrstWebApp.Models
{
    public partial class ShopLapOnlineContext : DbContext
    {
        public ShopLapOnlineContext()
        {
        }

        public ShopLapOnlineContext(DbContextOptions<ShopLapOnlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Favourite> Favourites { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderHistory> OrderHistories { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<ProductStatus> ProductStatuses { get; set; }
        public virtual DbSet<ProductsSpecifiedAttribute> ProductsSpecifiedAttributes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<SliderColection> SliderColections { get; set; }
        public virtual DbSet<SpecifiedAttribute> SpecifiedAttributes { get; set; }
        public virtual DbSet<SpecifiedAttributeValue> SpecifiedAttributeValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=BENJAMIN;Database=ShopLapOnline;user=sa;password=12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UQ__Accounts__C9F2845681499BCE")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.Cookie)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasColumnType("ntext");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Validator)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Role");
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.AdminId)
                    .ValueGeneratedNever()
                    .HasColumnName("Admin_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EmailContact).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("ntext");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AdminNavigation)
                    .WithOne(p => p.Admin)
                    .HasForeignKey<Admin>(d => d.AdminId)
                    .HasConstraintName("FK_Admin_Account");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.PreviewImage)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.PreviewImage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("Customer_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EmailContact).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("ntext");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithOne(p => p.Customer)
                    .HasForeignKey<Customer>(d => d.CustomerId)
                    .HasConstraintName("FK_Customer_Account");
            });

            modelBuilder.Entity<Favourite>(entity =>
            {
                entity.HasKey(e => e.FavouritesId)
                    .HasName("PK__Favourit__A57D5F36214E9DE4");

                entity.Property(e => e.FavouritesId).HasColumnName("Favourites_ID");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Favourites)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favourite_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Favourites)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Favourite_Product");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasIndex(e => e.OrderDetailId, "UQ__Feedback__53D880E191C0850C")
                    .IsUnique();

                entity.Property(e => e.FeedbackId).HasColumnName("Feedback_ID");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetail_ID");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Customer");

                entity.HasOne(d => d.OrderDetail)
                    .WithOne(p => p.Feedback)
                    .HasForeignKey<Feedback>(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_OrderDetail");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoteOrder).HasColumnType("ntext");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleId).HasColumnName("Sale_ID");

                entity.Property(e => e.TotalTransaction).HasColumnType("money");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_Order_Sale");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetail_ID");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<OrderHistory>(entity =>
            {
                entity.ToTable("OrderHistory");

                entity.Property(e => e.OrderHistoryId).HasColumnName("OrderHistory_ID");

                entity.Property(e => e.OrderHistoryTime).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatus_ID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderHistories)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderHistory_Order");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.OrderHistories)
                    .HasForeignKey(d => d.OrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderHistory_OrderStatus");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatus_ID");

                entity.Property(e => e.OrderStatusName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InitialPrice).HasColumnType("money");

                entity.Property(e => e.OriginalPrice).HasColumnType("money");

                entity.Property(e => e.PreviewImage).HasColumnType("ntext");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Product_Brand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Product_ProductStatus");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.Property(e => e.ProductDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductDetail_ID");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Images).HasColumnType("ntext");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProductDetailNavigation)
                    .WithOne(p => p.ProductDetail)
                    .HasForeignKey<ProductDetail>(d => d.ProductDetailId)
                    .HasConstraintName("FK_ProductDetail_Product");
            });

            modelBuilder.Entity<ProductStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__ProductS__519009AC744A8376");

                entity.ToTable("ProductStatus");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProductsSpecifiedAttribute>(entity =>
            {
                entity.ToTable("Products_SpecifiedAttribute");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.SpecifiedAttributeValueId).HasColumnName("SpecifiedAttributeValue_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsSpecifiedAttributes)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Products_SpecifiedAttribute_Product");

                entity.HasOne(d => d.SpecifiedAttributeValue)
                    .WithMany(p => p.ProductsSpecifiedAttributes)
                    .HasForeignKey(d => d.SpecifiedAttributeValueId)
                    .HasConstraintName("FK_Products_SpecifiedAttribute_SpecifiedAttributeValue");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.SaleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Sale_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.EmailContact).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Image).HasColumnType("ntext");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.SaleNavigation)
                    .WithOne(p => p.Sale)
                    .HasForeignKey<Sale>(d => d.SaleId)
                    .HasConstraintName("FK_Sale_Account");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.Property(e => e.SliderId).HasColumnName("Slider_ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.SliderColectionId).HasColumnName("SliderColection_ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Sliders)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Slider_Product");

                entity.HasOne(d => d.SliderColection)
                    .WithMany(p => p.Sliders)
                    .HasForeignKey(d => d.SliderColectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Slider_SliderColection");
            });

            modelBuilder.Entity<SliderColection>(entity =>
            {
                entity.ToTable("SliderColection");

                entity.Property(e => e.SliderColectionId).HasColumnName("SliderColection_ID");

                entity.Property(e => e.AdminId).HasColumnName("Admin_ID");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SliderColectionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.SliderColections)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SliderColection_Admin");
            });

            modelBuilder.Entity<SpecifiedAttribute>(entity =>
            {
                entity.ToTable("SpecifiedAttribute");

                entity.Property(e => e.SpecifiedAttributeId).HasColumnName("SpecifiedAttribute_ID");

                entity.Property(e => e.SpecifiedAttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpecifiedAttributeQueryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpecifiedAttributeValue>(entity =>
            {
                entity.ToTable("SpecifiedAttributeValue");

                entity.Property(e => e.SpecifiedAttributeValueId).HasColumnName("SpecifiedAttributeValue_ID");

                entity.Property(e => e.SpecifiedAttributeId).HasColumnName("SpecifiedAttribute_ID");

                entity.Property(e => e.SpecifiedAttributeValueName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.SpecifiedAttribute)
                    .WithMany(p => p.SpecifiedAttributeValues)
                    .HasForeignKey(d => d.SpecifiedAttributeId)
                    .HasConstraintName("FK_SpecifiedAttributeValue_SpecifiedAttribute");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
