using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
