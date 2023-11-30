using DesafioAeC.Automation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioAeC.Automation.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<SearchResult> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraRPA;Trusted_Connection=True;");
        }
    }
}
