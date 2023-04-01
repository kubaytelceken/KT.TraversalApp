using KT.Traversal.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KT.TraversalApp.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.RoutesCount = c.Destinations.Count();
            ViewBag.GuidesCount = c.Guides.Count();
            
            return View();
        }
    }
}
