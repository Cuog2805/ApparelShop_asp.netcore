using ApparelShop.Models.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Type = ApparelShop.Models.Properties.Type;

namespace ApparelShop.Models
{
    public class ApparelDBContext : DbContext
    {
        public ApparelDBContext(DbContextOptions<ApparelDBContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<CategoryItem> CategoryItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserObject> UserObjects { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminProduct> AdminProducts { get; set; }
        public DbSet<AdminCustomer> AdminCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //tạo khóa chính
            modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
            modelBuilder.Entity<ProductImage>().HasKey(pi => pi.ProductImageID);
            modelBuilder.Entity<Color>().HasKey(p => p.ColorID);
            modelBuilder.Entity<Color>().HasKey(c => c.ColorID);
            modelBuilder.Entity<Size>().HasKey(s => s.SizeID);
            modelBuilder.Entity<CategoryItem>().HasKey(ci => ci.CategoryItemID);
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryID);
            modelBuilder.Entity<UserObject>().HasKey(u => u.UserOjectID);
            modelBuilder.Entity<Type>().HasKey(t => t.TypeID);

            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerID);
            modelBuilder.Entity<Address>().HasKey(a => a.AddressID);
            modelBuilder.Entity<Discount>().HasKey(d => d.DiscountID);
            modelBuilder.Entity<Order>().HasKey(o => o.OrderID);
            modelBuilder.Entity<History>().HasKey(h => h.HistoryID);
            modelBuilder.Entity<Cart>().HasKey(c => c.CartID);
            modelBuilder.Entity<CartItem>().HasKey(ci => ci.CartItemID);
            modelBuilder.Entity<Wishlist>().HasKey(w => w.WishlistID);

            modelBuilder.Entity<Admin>().HasKey(a => a.AdminID);

            //product
            //product-productImage, 1-n
            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductImages)
                .WithOne(pi => pi.Product)
                .HasForeignKey("ProductID").IsRequired();
            //product-color, n-n
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Colors)
                .WithMany(c => c.Products)
                .UsingEntity(
                    "ProductColor",
                    l => l.HasOne(typeof(Color)).WithMany().HasForeignKey("ColorID").HasPrincipalKey(nameof(Color.ColorID)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductID").HasPrincipalKey(nameof(Product.ProductID)),
                    j => j.HasKey("ProductID", "ColorID"));

            //product-size, n-n
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Sizes)
                .WithMany(s => s.Products)
                .UsingEntity(
                    "ProductSize",
                    l => l.HasOne(typeof(Size)).WithMany().HasForeignKey("SizeID").HasPrincipalKey(nameof(Size.SizeID)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductID").HasPrincipalKey(nameof(Product.ProductID)),
                    j => j.HasKey("ProductID", "SizeID"));
            //product-categoryItem, n-n
            modelBuilder.Entity<Product>()
                .HasMany(p => p.CategoryItems)
                .WithMany(ci => ci.Products)
                .UsingEntity(
                    "ProductSize",
                    l => l.HasOne(typeof(CategoryItem)).WithMany().HasForeignKey("CategoryItemID").HasPrincipalKey(nameof(CategoryItem.CategoryItemID)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductID").HasPrincipalKey(nameof(Product.ProductID)),
                    j => j.HasKey("ProductID", "CategoryItemID"));
            //product-type, n-n
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Types)
                .WithMany(t => t.Products)
                .UsingEntity(
                    "ProductType",
                    l => l.HasOne(typeof(Type)).WithMany().HasForeignKey("TypeID").HasPrincipalKey(nameof(Type.TypeID)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductID").HasPrincipalKey(nameof(Product.ProductID)),
                    j => j.HasKey("ProductID", "TypeID"));

            //category-categoryItem, 1-n
            modelBuilder.Entity<Category>()
                .HasMany(c => c.CategorieItems)
                .WithOne(ci => ci.Category)
                .HasForeignKey("CategoryID").IsRequired();

            //userobject-category, 1-n
            modelBuilder.Entity<Category>()
                .HasOne(c => c.UserObject)
                .WithMany(u => u.Categories)
                .HasForeignKey("UserOjectID").IsRequired();

            //userobject-type, 1-n
            modelBuilder.Entity<Type>()
                .HasOne(t => t.UserObject)
                .WithMany(u => u.Types)
                .HasForeignKey("UserObjectID").IsRequired();


            //admin
            //product-adminProduct-admin, n-n
            modelBuilder.Entity<AdminProduct>()
                .HasKey(a => new { a.AdminID, a.ProductID });
            modelBuilder.Entity<Product>()
                .HasMany(p => p.AdminProducts)
                .WithOne(ap => ap.Products).HasForeignKey(ap => ap.ProductID).IsRequired();
            modelBuilder.Entity<Admin>()
                .HasMany(a => a.AdminProducts)
                .WithOne(ap => ap.Admins).HasForeignKey(ap => ap.AdminID).IsRequired();
            //customer-adminCustomer-admin, n-n
            modelBuilder.Entity<AdminCustomer>()
                .HasKey(a => new { a.AdminID, a.CustomerID });
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.AdminCustomers)
                .WithOne(ac => ac.Customers).HasForeignKey(ac => ac.CustomerID).IsRequired();
            modelBuilder.Entity<Admin>()
                .HasMany(a => a.AdminCustomers)
                .WithOne(ac => ac.Admins).HasForeignKey(ac => ac.AdminID).IsRequired();

            //customer
            //discount-customer, n-n
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Discounts)
                .WithMany(d => d.Customer)
                .UsingEntity(
                    "CustomerDiscount",
                    l => l.HasOne(typeof(Discount)).WithMany().HasForeignKey("DiscountID").HasPrincipalKey(nameof(Discount.DiscountID)),
                    r => r.HasOne(typeof(Customer)).WithMany().HasForeignKey("CustomerID").HasPrincipalKey(nameof(Customer.CustomerID)),
                    j => j.HasKey("CustomerID", "DiscountID"));
            //address-customer, n-1
            modelBuilder.Entity<Address>()
                .HasOne(a => a.Customer)
                .WithMany(c => c.AddressList)
                .HasForeignKey("CustomerID").IsRequired();
            //cart-customer, 1-1
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Customer)
                .WithOne(c => c.Cart)
                .HasForeignKey<Cart>("CustomerID").IsRequired();
            //cart-cartItem, 1-n
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey("CartID");
            //history-customer, 1-1
            modelBuilder.Entity<History>()
                .HasOne(h => h.Customer)
                .WithOne(c => c.History)
                .HasForeignKey<History>("CustomerID")
                .OnDelete(DeleteBehavior.Restrict);
            //history-cartItem, 1-n
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.History)
                .WithMany(h => h.CartItems)
                .HasForeignKey("HistoryID")
                .OnDelete(DeleteBehavior.Restrict);
            //order-customer, 1-n
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey("CustomerID").IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            //order-cartItem, 1-n
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Order)
                .WithMany(o => o.CartItems)
                .HasForeignKey("OrderID")
                .OnDelete(DeleteBehavior.Restrict);
            //product-cartItem, 1-n
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey("ProductID").IsRequired();

            //product-intermidiate-customer, n-n--1-1
            //wishlist-customer, 1-1
            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.Customer)
                .WithOne(c => c.Wishlist)
                .HasForeignKey<Wishlist>("CustomerID");
            //wishlist - product, n - n
            modelBuilder.Entity<Product>()
                .HasMany(w => w.Wishlists)
                .WithMany(p => p.Products)
                .UsingEntity(
                    "ProductWishlist",
                    l => l.HasOne(typeof(Wishlist)).WithMany().HasForeignKey("WishlistID").HasPrincipalKey(nameof(Wishlist.WishlistID)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductID").HasPrincipalKey(nameof(Product.ProductID)),
                    j => j.HasKey("ProductID", "WishlistID"));

            //product-review-customer
            modelBuilder.Entity<Review>()
                .HasKey(r => new { r.CustomerID, r.ProductID });
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Customers)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CustomerID).IsRequired();
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Products)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductID).IsRequired();


            base.OnModelCreating(modelBuilder);
        }
    }
}
