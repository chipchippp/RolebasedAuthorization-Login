using System.ComponentModel.DataAnnotations;

namespace RolebasedAuthorization.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public string MonthName { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        public int TotalOrders { get; set; }
        
    }
}
