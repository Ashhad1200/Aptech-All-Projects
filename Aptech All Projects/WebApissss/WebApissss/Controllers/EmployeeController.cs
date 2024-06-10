using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApissss.Data;

namespace WebApissss.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly lalaContext _lalaContext;

        public EmployeeController(lalaContext _lalaContext)
        {
            this._lalaContext = _lalaContext;
        }

        [HttpGet]
        public IActionResult EmployeeGet()
        {
            var Emp = _lalaContext.employees.ToList();
            return Ok(Emp);
        }
        [HttpPost]
        public IActionResult EmployeePost(employee employee)
        {
            var emp = new employee()
            {
                name = employee.name,
            };
            var re = _lalaContext.employees.Add(emp);
            _lalaContext.SaveChanges();
            return Ok(re);
        }
        [HttpPut]
        public IActionResult EmployeePut(employee employee)
        {
            var emp = _lalaContext.employees.FirstOrDefault(e => e.id == employee.id);
            if (emp == null)
            {
                return NotFound(); 
            }

            emp.name = employee.name;
            _lalaContext.SaveChanges();

            return Ok(emp);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = _lalaContext.employees.FirstOrDefault(e => e.id == id); // Assuming there's an ID property for employees
            if (emp == null)
            {
                return NotFound(); // If employee with given ID is not found
            }

            _lalaContext.employees.Remove(emp);
            _lalaContext.SaveChanges();

            return Ok(emp);
        }
    }
}
