using Microsoft.EntityFrameworkCore;

namespace EmployeeSystem.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        DbSet<Department> departments { get; set; }
        DbSet<Employee> employees { get; set; }
    }
}
