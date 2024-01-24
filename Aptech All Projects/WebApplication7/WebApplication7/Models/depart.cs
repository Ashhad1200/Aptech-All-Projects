using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class depart
    {
        [Key]
        public int Depart_Id { get; set; }

        public string Dapart_name { get; set; }
    }
}
