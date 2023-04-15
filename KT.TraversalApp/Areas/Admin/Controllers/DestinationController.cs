using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using KT.Traversal.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        public IActionResult Index()
        {
            var destinationList = destinationManager.TGetList();
            return View(destinationList);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult AddDestination(Destination destination) 
        {
            destinationManager.TAdd(destination);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            var destination = destinationManager.TGetById(id);
            destinationManager.TDelete(destination);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var destination = destinationManager.TGetById(id);
            return View(destination);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            destinationManager.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
