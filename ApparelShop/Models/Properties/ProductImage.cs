using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class ProductImage
    {
        public int ProductImageID { get; set; }
        public string Url { get; set; }
        public bool IsAvatar { get; set; } = false;
        public virtual Product Product { get; set; }
    }
}
