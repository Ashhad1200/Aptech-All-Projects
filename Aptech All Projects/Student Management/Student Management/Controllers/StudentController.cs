using Microsoft.AspNetCore.Mvc;

namespace Student_Management.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentProfile()
        {
            return View();
        }
    }
}
