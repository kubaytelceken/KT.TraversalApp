using KT.Traversal.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KT.TraversalApp.ViewComponents.MemberDashboard
{
    public class _ProfileInformation : ViewComponent
    {
        private readonly UserManager<AppUser> userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.MemberName = user.Name + " " + user.Surname;
            ViewBag.MemberMail = user.Email;
            ViewBag.MemberPhone = user.PhoneNumber;

            return View();
        }
    }
}
