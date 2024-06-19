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


namespace OyunHaberSitesi.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        readonly UserManager um = new UserManager(new EFUserDAL());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUserList()
        {
            var uservalues = um.GetList();
            return View(uservalues);
        }

        [HttpDelete]
        public ActionResult DeleteUser(int id)
        {
            var uservalues = um.GetById(id);
            if (uservalues != null)
            {
                um.Delete(uservalues);
                return RedirectToAction("GetUserList");
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult EditUser(int id)
        {
            var user = um.GetById(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult EditUser(User user)
        {
            um.Update(user);
            return RedirectToAction("GetUserList");
        }
    }
}