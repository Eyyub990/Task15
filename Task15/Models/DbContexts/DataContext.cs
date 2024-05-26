using Microsoft.EntityFrameworkCore;
using Task15.Models.Entities;

namespace Task15.Models.DbContexts
{
    public class DataContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DataContext(DbContextOptions options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
