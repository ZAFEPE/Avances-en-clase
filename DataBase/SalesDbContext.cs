using Microsoft.EntityFrameworkCore;
using Sales.API.Entities;

namespace Sales.API.DataBase
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext (DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<CategoryEntity> Categories { get; set; }


    }
}