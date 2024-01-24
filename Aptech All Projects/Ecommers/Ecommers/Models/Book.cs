namespace Ecommers.Models
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
    }
}
