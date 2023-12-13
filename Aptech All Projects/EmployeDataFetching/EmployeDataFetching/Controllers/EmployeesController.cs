using Microsoft.AspNetCore.Mvc;
using EmployeDataFetching.Models;
namespace EmployeDataFetching.Controllers

{
    public class EmployeesController : Controller
    {
        public IActionResult employeeDataFetch()
        {
            EmployeeData Ashhad = new EmployeeData
            {
                id = 1,
                name = "Syed Ashhad",
                age = 23,
                description = "This Is Syed Ashhad And This Data Is Fetching By MVC"
            };
            ViewBag.ashhadData = Ashhad;
            return View();
        }
    }
}
