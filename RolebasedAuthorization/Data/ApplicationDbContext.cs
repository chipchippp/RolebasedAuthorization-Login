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
        public DbSet<RolebasedAuthorization.Models.Student> Student { get; set; } = default!;
        public DbSet<RolebasedAuthorization.Models.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<RolebasedAuthorization.Models.Course> Course { get; set; } = default!;
    }
}
