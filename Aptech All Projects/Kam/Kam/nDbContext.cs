using Kam.Models;
using Microsoft.EntityFrameworkCore;

namespace Kam
{
    public class nDbContext : DbContext
    {
        public nDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> employees { get; set; }
    }
}
