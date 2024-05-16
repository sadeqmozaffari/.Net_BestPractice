using Microsoft.EntityFrameworkCore;
using Project_01.Entities;

namespace Project_01.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }
        public DbSet<Article> Articles { get; set; }
    }
}
