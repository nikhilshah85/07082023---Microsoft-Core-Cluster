using Microsoft.AspNetCore.Mvc;
using firstMVC.Models;
namespace firstMVC.Controllers
{
    public class productController : Controller
    {

        productList pObj = new productList(); //this is not good, we should use DI - dependency injection instead of this code

        public IActionResult ProductsList()
        {
            //view bag is a variable which will take data from controller to view
            //viewbad is getting data from model
            ViewBag.products = pObj.GetAllProducts();
            return View();
        }

    }
}
