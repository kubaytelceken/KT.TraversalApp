using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
