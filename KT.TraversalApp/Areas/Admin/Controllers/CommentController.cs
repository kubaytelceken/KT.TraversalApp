using KT.Traversal.Business.Abstract;
using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KT.TraversalApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var commentList = _commentService.TGetListCommentWithDestination();
            return View(commentList);
        }


        public IActionResult DeleteComment(int id)
        {
            var comment = _commentService.TGetById(id);
            _commentService.TDelete(comment);
            return RedirectToAction("Index");


        }
    }
}
