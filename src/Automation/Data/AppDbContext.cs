using DesafioAeC.AluraRPA.Data;
using DesafioAeC.Automation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioAeC.Automation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SearchResult> Results { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SearchResultEntityTypeConfiguration());
        }
    }
}
