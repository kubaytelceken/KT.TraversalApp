using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.ViewComponents.Default
{

    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetList();
            return View(values);  
        }
    }
}
