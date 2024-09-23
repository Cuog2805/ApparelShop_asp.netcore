using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Size
    {
        public int SizeID { get; set; }
        public string Value { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
