using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class AdminProduct
    {
        public int AdminID { get; set; }
        public int ProductID { get; set; }
        public string Action { get; set; }
        public DateTime ActionTime { get; set; } = DateTime.Now;
        //
        public virtual Product Products { get; set; }
        public virtual Admin Admins { get; set; }
    }
}
