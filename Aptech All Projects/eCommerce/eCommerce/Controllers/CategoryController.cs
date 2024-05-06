using Azure;
using eCommerce.Data;
using eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;
namespace eCommerce.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext applicationDBContext;

        public CategoryController(ApplicationDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }


        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTag(Category addCategory)
        {
            var tag = new Category
            {
                CategoryName = addCategory.CategoryName,
            };
            applicationDBContext.Categories.Add(addCategory);
            applicationDBContext.SaveChanges();
            return View();
        }

    }
}
