using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}
