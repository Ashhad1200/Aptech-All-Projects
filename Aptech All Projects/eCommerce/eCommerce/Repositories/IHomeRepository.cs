using eCommerce.Models;

namespace eCommerce
{
    public interface IHomeRepository
    {
        public Task<IEnumerable<Book>> displayBooks(string sTerm = "", int categoryId = 0);
    }
}