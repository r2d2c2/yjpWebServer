using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace yjpweb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<DataClass> mydata { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}