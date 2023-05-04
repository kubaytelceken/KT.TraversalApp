using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
