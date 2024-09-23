using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CategoryItem> CategorieItems { get; set; }
        public virtual UserObject UserObject { get; set; }
    }
}
