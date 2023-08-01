using DB_MS.Data.Configurations;
using DB_MS.Models;
using Microsoft.EntityFrameworkCore;

namespace Vertour_C_Sharp.Data
{
    public class BizDoContext : DbContext
    {
        public BizDoContext(DbContextOptions<BizDoContext> options) : base(options)
        {

        }
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasIndex(x=>x.name).IsUnique();
            modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
        }
    }
}
