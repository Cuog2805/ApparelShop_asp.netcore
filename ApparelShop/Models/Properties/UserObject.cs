using System.ComponentModel.DataAnnotations;

namespace ApparelShop.Models.Properties
{
    public class UserObject
    {
        public int UserOjectID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Type> Types { get; set; }
    }
}
