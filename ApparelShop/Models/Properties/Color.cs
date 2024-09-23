using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Color
    {
        public int ColorID { get; set; }
        public string Value { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
