using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        [ForeignKey("department")]
        public int DepartmentId { get; set; }

    }
}
