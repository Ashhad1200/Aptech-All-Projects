using Ecommers.Data;
using Ecommers.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace Ecommers.Controllers
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
		public IActionResult AddBlog(Book book, IFormFile imgfile)
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
				book.Image = dbi;
				applicationDBContext.Books.Add(book);
				applicationDBContext.SaveChanges();
			}
			return View();

		}

		public IActionResult FetchBooks()
		{
			return View(applicationDBContext.Books.ToList());
		}

		public IActionResult deleteBooks(int id)
		{
			Book book = applicationDBContext.Books.Find(id);
			applicationDBContext.Books.Remove(book);
			applicationDBContext.SaveChanges();
			return RedirectToAction("FetchBooks");
		}

		public IActionResult editBook(int id)
		{
			return View(applicationDBContext.Books.Find(id));
		}

	}
}
