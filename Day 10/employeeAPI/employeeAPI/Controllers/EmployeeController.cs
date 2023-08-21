using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace employeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        [Route("/employee/list")]
        public IActionResult EmployeeNames()
        {
            List<string> empNames = new List<string>()
            {
                "Nikhil","Karan","Mohan","Karthik","Akshay","Rohan", "Sumit"

            };

            return Ok(empNames);
        }
    }
}
