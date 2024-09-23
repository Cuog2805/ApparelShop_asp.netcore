using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float? PriceDecreased { get; set; }
        public string? Material { get; set; }
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        public float Rate { get; set; } = 0;
        public DateTime? Published { get; set; } = DateTime.Now;
        //navigation property
        public virtual ICollection<Size> Sizes { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
        public virtual ICollection<Type> Types { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
        public virtual ICollection<AdminProduct> AdminProducts { get; set; }
    }
}
