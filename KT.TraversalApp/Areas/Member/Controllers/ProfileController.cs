using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
