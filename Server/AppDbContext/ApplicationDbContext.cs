using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
