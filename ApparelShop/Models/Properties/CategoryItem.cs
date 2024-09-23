using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class CategoryItem
    {
        public int CategoryItemID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual Category Category { get; set; }
    }
}
