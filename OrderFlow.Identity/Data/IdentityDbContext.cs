using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace OrderFlow.Identity.Data
//DBcontext for identity management
// Inheriits from IdentityDbContext to leverage built-in identity features
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // You can customize the ASP.NET Identity model and override the defaults if needed
            // For example, you can rename the ASP.NET Identity table names and more.
            // builder.Entity<IdentityUser>().ToTable("Users");
            // builder.Entity<IdentityRole>().ToTable("Roles");
        }
    }
}