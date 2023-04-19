using KT.Traversal.Business.Abstract;
using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using KT.Traversal.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
      


        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var destinationList = _destinationService.TGetList();
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
            _destinationService.TAdd(destination);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            var destination = _destinationService.TGetById(id);
            _destinationService.TDelete(destination);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var destination = _destinationService.TGetById(id);
            return View(destination);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
