using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using My_App_03d.Models;

namespace My_App_03d.Controllers
{
    public class UsersController : Controller
    {
        private UserContext db = new UserContext();
        public List<User> Users = new List<User>();
        public UserSession userSession;
        public ActionResult Index()
        {
            if(this.Session["ValidateSession"] != null)
            {
                userSession = this.Session["ValidateSession"] as UserSession;
                if(userSession.UserName != null)
                {
                    return View(db.Users.ToList());
                }
            }
            ViewBag.MustLoginToViewUsers = true;
            return View("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            this.Session["ValidateSession"] = null;
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "UserID, Username, Password")] User user)
        {
            if(ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occured");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "UserName, Password")] UserLoginView userLoginView)
        {
            if (ModelState.IsValid)
            {
                var usr = db.Users.Where(u => u.UserName == userLoginView.UserName).FirstOrDefault();
                if (usr != null)
                {
                    if (usr.Password == userLoginView.Password)
                    {
                        var session = new UserSession()
                        {
                            UserID = usr.UserID,
                            UserName = usr.UserName,

                        };
                        this.Session["ValidateSession"] = session;
                        return RedirectToAction("LoggedIn");
                    }
                    else
                    {
                        ViewBag.InvalidPassword = true;
                        userLoginView.Password = null;
                        return View(userLoginView);
                    }


                }
                return RedirectToAction("Login");

            }
            return View(userLoginView);
        }

        [HttpGet]
        public ActionResult LoggedIn()
        {
            if (Session["ValidateSession"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
