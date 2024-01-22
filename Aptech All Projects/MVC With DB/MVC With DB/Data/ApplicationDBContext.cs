using Microsoft.EntityFrameworkCore;
using MVC_With_DB.Models;

namespace MVC_With_DB.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
