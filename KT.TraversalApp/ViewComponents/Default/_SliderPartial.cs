using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
