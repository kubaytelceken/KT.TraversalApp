using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialRepository());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);  
        }
    }
}
