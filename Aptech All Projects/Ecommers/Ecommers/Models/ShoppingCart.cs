namespace Ecommers.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
