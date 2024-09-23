using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class CartItem
    {
        public int CartItemID { get; set; }
        public int Quantity { get; set; }
        public float Total { get; set; }
        //
        public virtual Cart? Cart { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Order? Order { get; set; }
        public virtual History? History { get; set; }
    }
}
