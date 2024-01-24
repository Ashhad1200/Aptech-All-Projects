using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }

        public string Emp_name { get; set; }

        public string Emp_age { get; set; }

        public string Emp_email { get; set; }

    }
}
