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
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;
using BusinessLayer.Abstract;

namespace OyunHaberSitesi.Controllers
{
    [Authorize]
    public class NewController : Controller
    {
        private readonly NewManager nm = new NewManager(new EFNewDAL());
        public ActionResult Index()
        {
            var newvalues = nm.GetList();
            return View(newvalues);
        }
        public ActionResult News(int id)
        {
            var newid = nm.GetById(id);
            return View(newid);
        }
        public ActionResult GetNewList()
        {
            var newvalues = nm.GetList();
            return View(newvalues);
        }
        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNew(New p)
        {
            NewValidator newValidator = new NewValidator();
            ValidationResult results = newValidator.Validate(p);
            if (results.IsValid)
            {
                nm.NewAdd(p);
                return RedirectToAction("GetNewList");
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
        public ActionResult DeleteNew(int id)
        {
            var newToDelete = nm.GetById(id);

            if (newToDelete != null)
            {
                nm.Delete(newToDelete);
                return RedirectToAction("GetNewList");
            }
            else
            {
                return HttpNotFound();
            }
        }
        public ActionResult EditNew(int id)
        {
            var @new = nm.GetById(id);
            return View(@new);
        }

        [HttpPost]
        public ActionResult EditNew(New @new)
        {
            nm.Update(@new);
            return RedirectToAction("GetNewList");
        }

        public static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength) + "...";
        }



    }
}


        
    