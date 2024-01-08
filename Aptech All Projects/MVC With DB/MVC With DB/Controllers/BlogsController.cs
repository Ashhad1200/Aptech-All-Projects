using Microsoft.AspNetCore.Mvc;
using MVC_With_DB.Data;
using MVC_With_DB.Models;
using static System.Net.Mime.MediaTypeNames;

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
        public IActionResult AddBlog(Blog addBlog , IFormFile blogImage)
        {
            if (blogImage =! null && blogImage.Length>0)
            {

            }

            var blog = new Blog
            {
                Title = addBlog.Title,
                Subheading = addBlog.Subheading,
                Description = addBlog.Description,
                Content= addBlog.Content,
                Author = addBlog.Author,
                Image = addBlog.Image
            };
            applicationDBContext.Blogs.Add(addBlog);
            applicationDBContext.SaveChanges();

            return View();
        }
        public IActionResult Fetch()
        {
            return View(applicationDBContext.Blogs.ToList());
        }

        public IActionResult deleteBlog(int id)
        {
            Blog blog = applicationDBContext.Blogs.Find(id);
            applicationDBContext.Blogs.Remove(blog);
            applicationDBContext.SaveChanges();
            return RedirectToAction("Fetch");
        }

        public IActionResult editBlog(int id)
        {
            return View(applicationDBContext.Blogs.Find(id));
        }

        [HttpPost]
        public IActionResult editBlog(Blog blog)
        {
            applicationDBContext.Blogs.Update(blog);
            applicationDBContext.SaveChanges();
            return RedirectToAction("Fetch");
        }

    }
}
