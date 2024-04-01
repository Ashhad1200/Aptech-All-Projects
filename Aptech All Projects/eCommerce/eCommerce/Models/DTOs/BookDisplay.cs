namespace eCommerce.Models.DTOs
{
    public class BookDisplay
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories{ get; set; }
    }
}
