using Microsoft.EntityFrameworkCore;

namespace WebApissss.Data
{
    public class lalaContext : DbContext
    {
        public lalaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<employee> employees { get; set; }  
        public DbSet<Department> departments { get; set; }

    }
}
