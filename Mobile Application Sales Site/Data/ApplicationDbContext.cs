using Microsoft.EntityFrameworkCore;
namespace Mobile_Application_Sales_Site.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
    }
}
