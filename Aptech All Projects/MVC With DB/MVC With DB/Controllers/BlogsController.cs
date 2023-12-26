using Microsoft.AspNetCore.Mvc;
using MVC_With_DB.Data;
using MVC_With_DB.Models;

namespace MVC_With_DB.Controllers
{
    public class BlogsController : Controller
    {
        private readonly ApplicationDBContext applicationDBContext;

        public BlogsController( ApplicationDBContext applicationDBContext )
        {
            this.applicationDBContext = applicationDBContext;
        }
        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog addBlog)
        {
            var blog = new Blog
            {
                Title = addBlog.Title,
                Subheading = addBlog.Subheading,
                Description = addBlog.Description
            };
            applicationDBContext.Add(addBlog);
            applicationDBContext.SaveChanges();

            return View();
        }
    }
}
