using Microsoft.AspNetCore.Mvc;

namespace shoppingAPP_MVC.Controllers
{
    public class ProductsController : Controller
    {     

        public IActionResult ProductList()
        {
            return View();
        }

        public IActionResult topsellingproducts()
        {
            return View();
        }

        public IActionResult buyagain()
        {
            return View();
        }

        public IActionResult offers()
        {
            return View();
        }

    }
}
