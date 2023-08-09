using Microsoft.AspNetCore.Mvc;
using empmanagement_ado_mvc.Models;
namespace empmanagement_ado_mvc.Controllers
{
    public class EmployeeController : Controller
    {

        EmployeeModel eObj = new EmployeeModel(); // we should use DI instead



        public IActionResult EmployeeList()
        {
            ViewBag.eList = eObj.GetAllEmployees();
            return View();
        }

        public IActionResult AddNewEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewEmployee(EmployeeModel newEmp)
        {
            ViewBag.addresult = eObj.AddNewEmployee(newEmp);
            return View();
        }
    }
}






