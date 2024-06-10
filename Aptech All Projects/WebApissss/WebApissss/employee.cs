using System.ComponentModel.DataAnnotations;

namespace WebApissss
{
    public class employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }

    }
}
