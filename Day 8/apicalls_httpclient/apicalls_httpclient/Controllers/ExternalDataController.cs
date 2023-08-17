using apicalls_httpclient.Models;
using Microsoft.AspNetCore.Mvc;

namespace apicalls_httpclient.Controllers
{
    public class ExternalDataController : Controller
    {

        CommentDetails commentObj = new CommentDetails(); // we should use DI instead of createing new obj
        public IActionResult Comments()
        {
            ViewBag.comments = commentObj.GetComments();
            return View();
        }
    }
}
