using EmployeeSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    public class DepartmentController : Controller
    {


        private readonly Context applicationDBContext;

        public DepartmentController(Context applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
