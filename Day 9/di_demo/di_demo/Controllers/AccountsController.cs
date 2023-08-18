using di_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace di_demo.Controllers
{
    public class AccountsController : Controller
    {

        //  accounts accObj = new accounts(); //this not good, use DI insted

        accounts _accObj; //this object will be created by runtime and will be injected inside controller

        //tell runtime to inject the object here
        public AccountsController(accounts _accObjREF)
        {
            _accObj = _accObjREF;
        }


        public IActionResult DisplayAccounts()
        {
            ViewBag.acc = _accObj.GetAllAccounts();
            return View();
        }
    }
}
