using KT.Traversal.Business.Abstract;
using KT.Traversal.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuestController : Controller
    {
        private readonly IAppUserService _appUserService;

        public GuestController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
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

   

    }
}
