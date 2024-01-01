using Microsoft.AspNetCore.Mvc;
using MVC_With_DB.Data;
using MVC_With_DB.Models;

namespace MVC_With_DB.Controllers
{
    public class TagsController : Controller
    {
        private readonly ApplicationDBContext applicationDBContext;

        public TagsController(ApplicationDBContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public IActionResult AddTag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTag(Tag addTag)
        {
            var tag = new Tag
            {
                Name = addTag.Name,
            };
            applicationDBContext.Tags.Add(addTag);
            applicationDBContext.SaveChanges();
            return View();
        }

        public IActionResult Fetch()
        {
            return View(applicationDBContext.Tags.ToList());
        }

      
        public IActionResult deleteTag(int id)
        {
           Tag tag = applicationDBContext.Tags.Find(id);
            applicationDBContext.Tags.Remove(tag);
            applicationDBContext.SaveChanges();
            return RedirectToAction("Fetch"); 
        }



    }
}