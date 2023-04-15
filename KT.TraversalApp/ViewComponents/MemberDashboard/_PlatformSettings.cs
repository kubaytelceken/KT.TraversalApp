using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.ViewComponents.MemberDashboard
{
    public class _PlatformSettings : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
