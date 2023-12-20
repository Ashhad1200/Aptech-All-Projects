using Microsoft.EntityFrameworkCore;
using MVC_With_DB.Models;

namespace MVC_With_DB.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Tag> Tags { get; set; }
        DbSet<Blog> Blogs { get; set; }
    }
}
