using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Cart
    {
        public int CartID { get; set; }
        public int Quantity { get; set; }
        public float Total { get; set; }
        //
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
