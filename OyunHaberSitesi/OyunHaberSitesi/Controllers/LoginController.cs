using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace OyunHaberSitesi.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _context;

        public LoginController()
        {
            _context = new Context();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User p)
        {
            Context c = new Context();
            var logreginfo = c.Users.FirstOrDefault(x => x.User_name == p.User_name && x.User_password == p.User_password);   /*&& x.User_writer == true*/
            if (logreginfo != null)
            {
                if (logreginfo.User_writer)
                {
                    FormsAuthentication.SetAuthCookie(logreginfo.User_name, false);
                    Session["User_name"] = logreginfo.User_name;
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(logreginfo.User_name, false);
                    Session["User_name"] = logreginfo.User_name;
                    return RedirectToAction("Index", "New");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public ActionResult Logout()
        {
            Session.Remove("User_name");
            return RedirectToAction("Index", "Login");
        }
        public ActionResult RegisterLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterLogin(string user_name, string user_mail, string user_password, bool user_writer, DateTime user_regdate)
        {
            try
            {
                var newUser = new User
                {
                    User_name = user_name,
                    User_mail = user_mail,
                    User_password = user_password,
                    User_writer = user_writer,
                    User_regdate = user_regdate
                };


                _context.Users.Add(newUser);
                _context.SaveChanges();

                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to save changes. " + ex.Message);
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
    }
