using eCommerce.Data;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace eCommerce.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext applicationDBContext;

        public BookController(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book books, IFormFile imgfile)
        {
            if (imgfile != null && imgfile.Length > 0)
            {
                var ff = Path.GetFileName(imgfile.FileName);
                Random rn = new Random();
                var ii = rn.Next(1, 200);
                var fn = ii + ff;
                var fol = Path.Combine(HttpContext.Request.PathBase.Value, "wwwroot/uploads");
                if (!Directory.Exists(fol))
                {
                    Directory.CreateDirectory(fol);
                    Directory.CreateDirectory(fol);
                }
                string fp = Path.Combine(fol, fn);
                using (var a = new FileStream(fp, FileMode.Create))
                {
                    imgfile.CopyTo(a);
                }
                var dbi = Path.Combine("uploads", fn);
                books.Image = dbi;
                applicationDBContext.Books.Add(books);
                applicationDBContext.SaveChanges();
            }
            return View();
        }

        public IActionResult deleteBook(int id)
        {
            Book book = applicationDBContext.Books.Find(id);
            applicationDBContext.Books.Remove(book);
            applicationDBContext.SaveChanges();
            return RedirectToAction("Fetch");
        }

    }
}
