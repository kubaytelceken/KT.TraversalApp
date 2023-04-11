using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using KT.Traversal.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace KT.TraversalApp.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        ReservationManager reservationManager = new ReservationManager(new EfReservationRepository());
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
            {
                Text= x.City,
                Value = x.Id.ToString()
            }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation model)
        {
            model.AppUserId = 3;
            reservationManager.TAdd(model); 
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
