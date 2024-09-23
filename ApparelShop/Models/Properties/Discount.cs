using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public DateTime? Expiry { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
