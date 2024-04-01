using eCommerce.Data;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext db;

        public HomeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Category>> displayCat()
        {
            return await db.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Book>> displayBooks(string sTerm = "", int categoryId = 0)
        {
            IEnumerable<Book> books = await (from book in db.Books
                                             join category in db.Categories
                                             on book.CategoryId equals category.Id
                                             where string.IsNullOrWhiteSpace(sTerm) || (book != null && book.BookName.ToLower().StartsWith(sTerm))

                                             select new Book
                                             {
                                                 Id = book.Id,
                                                 BookName = book.BookName,
                                                 Price = book.Price,
                                                 Author = book.Author,
                                                 Image = book.Image,
                                                 CategoryId = book.CategoryId,
                                                 CategoryName = book.CategoryName,



                                             }
                                       ).ToListAsync();

            if (categoryId > 0)
            {
                books = books.Where(a => a.CategoryId == categoryId).ToList();
            }

            return books;
        }




    }
}
