using Microsoft.EntityFrameworkCore;

namespace EFTutorial.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Vinyl> Vinyl { get; set; } 
    }
}
