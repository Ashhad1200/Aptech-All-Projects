using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }

        public Category category;
        public int CategoryId { get; set; }

        [NotMapped]
        public string CategoryName { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
        public List<CartDetails> CartDetails { get; set; }


    }
}
