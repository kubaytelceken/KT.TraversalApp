using KT.Traversal.Business.Concrete;
using KT.Traversal.DataAccessLayer.EntityFramework;
using KT.Traversal.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KT.TraversalApp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment model)
        {
            model.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            model.CommentState = true;
            model.DestinationId = 1;
            commentManager.TAdd(model);

            return RedirectToAction("Index","Destination");
        }
    }
}
