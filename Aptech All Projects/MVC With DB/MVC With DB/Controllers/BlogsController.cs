﻿using Microsoft.AspNetCore.Mvc;
using MVC_With_DB.Data;
using MVC_With_DB.Models;
using System.Reflection.Metadata;
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
        public IActionResult AddBlog(Blog blog, IFormFile imgfile)
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
                var dbi = Path.Combine("uploads",fn);
                blog.Image = dbi;
                applicationDBContext.Blogs.Add(blog);
                applicationDBContext.SaveChanges();
            }
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


        public IActionResult detailBlog(int id)
        {
            return View(applicationDBContext.Blogs.Find(id));
        }
    }
}
