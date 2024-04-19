namespace eCommerce.Models.DTOs
{
    public class BookDisplay
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories{ get; set; }

        public string Sterm { get; set; } = "";
        public int categoryId { get; set; } = 0;


    }
}
