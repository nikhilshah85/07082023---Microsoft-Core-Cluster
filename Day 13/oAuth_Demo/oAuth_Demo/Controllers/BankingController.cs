using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace oAuth_Demo.Controllers
{
    [Authorize]
    public class BankingController : Controller
    {
        [AllowAnonymous]
        public IActionResult BankingHome()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult AccountTypes()
        {
            return View();
        }

        public IActionResult TransferFunds()
        {
            return View();
        }

        public IActionResult DownloadStatement()
        {
            return View();
        }
    }
}
