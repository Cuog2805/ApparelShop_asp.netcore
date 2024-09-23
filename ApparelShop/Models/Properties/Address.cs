using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Content { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
