using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.ViewComponents.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
