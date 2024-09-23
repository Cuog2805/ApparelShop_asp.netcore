using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class AdminCustomer
    {
        public int AdminID { get; set; }
        public int CustomerID { get; set; }
        public string Action { get; set; }
        public DateTime ActionTime { get; set; } = DateTime.Now;
        //
        public virtual Customer Customers { get; set; }
        public virtual Admin Admins { get; set; }
    }
}
