using System.ComponentModel.DataAnnotations;

namespace RolebasedAuthorization.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public string MonthName { get; set; }
        public int TotalOrders { get; set; }

    }
}
