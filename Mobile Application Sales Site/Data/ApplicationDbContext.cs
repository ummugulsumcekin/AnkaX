using Microsoft.EntityFrameworkCore;
using Mobile_Application_Sales_Site.Models;

namespace Mobile_Application_Sales_Site.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
