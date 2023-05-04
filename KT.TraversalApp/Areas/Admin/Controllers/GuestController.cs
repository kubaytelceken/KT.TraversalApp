using KT.Traversal.Business.Abstract;
using KT.Traversal.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace KT.TraversalApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuestController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public GuestController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
           var guestList =  _appUserService.TGetList();
           return View(guestList);
        }

        public IActionResult DeleteUser(int id)
        {
            var guest = _appUserService.TGetById(id);
            _appUserService.TDelete(guest);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var guest = _appUserService.TGetById(id);
            return View(guest);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }


        public IActionResult ReservationUser(int id)
        {
            var reservationList = _reservationService.GetListWithReservationByApprove(id);
            return View(reservationList);
        }

   

    }
}
