using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        //navigation propertys
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Address> AddressList { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual History History { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual Wishlist Wishlist { get; set; }
        public virtual ICollection<AdminCustomer> AdminCustomers { get; set; }
    }
}
