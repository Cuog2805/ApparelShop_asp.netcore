using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        //
        public virtual ICollection<AdminProduct> AdminProducts { get; set; }
        public virtual ICollection<AdminCustomer> AdminCustomers { get; set; }
    }
}
