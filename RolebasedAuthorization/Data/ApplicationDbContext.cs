using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RolebasedAuthorization.Models;

namespace RolebasedAuthorization.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RolebasedAuthorization.Models.Orders> Orders { get; set; } = default!;
    }
}
