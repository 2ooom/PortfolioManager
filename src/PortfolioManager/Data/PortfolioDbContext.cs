using Microsoft.EntityFrameworkCore;
using PortfolioManager.Data.Model;

namespace PortfolioManager.Data
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./App_Data/PortfolioDb.db");
        }
    }
}
