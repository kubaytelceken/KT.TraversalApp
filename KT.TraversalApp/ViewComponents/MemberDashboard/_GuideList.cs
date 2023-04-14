using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KT.TraversalApp.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager _guideManager = new GuideManager(new EfGuideRepository());
        public IViewComponentResult Invoke()
        {
            var guideList = _guideManager.TGetList();
            return View(guideList);
        }
    }
}
