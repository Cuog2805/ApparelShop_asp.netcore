using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class Review
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public int Rate { get; set; }
        //
        public virtual Product Products { get; set; }
        public virtual Customer Customers { get; set; }
    }
}
