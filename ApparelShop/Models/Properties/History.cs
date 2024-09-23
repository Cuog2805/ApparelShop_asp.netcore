using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class History
    {
        public int HistoryID { get; set; }
        public int Quantity { get; set; }
        //
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
