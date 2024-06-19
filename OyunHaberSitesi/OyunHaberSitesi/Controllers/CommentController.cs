using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Abstract;

namespace OyunHaberSitesi.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        CommentManager com = new CommentManager(new EFCommentDAL());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCommentList()
        {
            var commentvalues = com.GetList();
            return View(commentvalues);
        }

        [HttpGet]
        public ActionResult AddComment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddComment(Comment c)
        {
            CommentValidator commentValidator = new CommentValidator();
            ValidationResult results = commentValidator.Validate(c);
            if (results.IsValid)
            {
                com.CommentAdd(c);
                return RedirectToAction("GetCommentList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpDelete]
        public ActionResult DeleteComment(int id)
        {
            var commentvalues = com.GetById(id);
            if (commentvalues != null)
            {
                com.Delete(commentvalues);
                return RedirectToAction("GetCommentList");
            }
            else
            {
                return HttpNotFound();
            }
        }


        public ActionResult EditComment(int id)
        {
            var comment = com.GetById(id);
            return View(comment);
        }
        [HttpPost]
        public ActionResult EditComment(Comment comment)
        {
            com.Update(comment);
            return RedirectToAction("GetCommentList");
        }
    }
}