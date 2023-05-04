using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {

            return View();
        }
    }
}
