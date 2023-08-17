using Microsoft.AspNetCore.Mvc;

namespace fetchAPI.Controllers
{
    public class ExternalDataController : Controller
    {
        public IActionResult UserPost()
        {
            return View();
        }
    }
}
