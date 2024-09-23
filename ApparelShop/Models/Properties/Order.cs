using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public DateTime Orderdate { get; set; } = DateTime.Now;
        //
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
