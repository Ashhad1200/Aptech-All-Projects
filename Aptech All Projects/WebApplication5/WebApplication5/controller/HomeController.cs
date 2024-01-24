
using Microsoft.AspNetCore.Mvc;

namespace withoutMiddleware.controller
{
    public class HomeController  : Controller
        {
        [Route("/index")]

        public IActionResult Data()
           {
        return View("~/view/Home/about.cshtml");
           }

    [Route("/home/about/{id}")]
    
    public int about (int id)
    {
        return id;
    }
         }
}
