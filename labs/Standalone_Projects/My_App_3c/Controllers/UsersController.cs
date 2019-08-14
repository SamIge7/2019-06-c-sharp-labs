using My_App_3c.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_App_3c.Controllers
{
    public class UsersController : Controller
    {
        private UserContext db = new UserContext();
        public UserSession usersession;
        public ActionResult Index()
        {
            if(this.Session["ValidSession"] != null)
            {
                usersession = this.Session["ValidSession"] as UserSession;
                if(usersession.Username != null)
                {
                    return View(db.Users.ToList());
                }
            }
            ViewBag.LoginToViewUsers = true;
            return View("Login");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
           if(ModelState.IsValid)
           {
                var existingUser = db.Users.Any(e => e.UserName == user.UserName);
                if (existingUser)
                {
                    ViewBag.ExistingUser = true;
                    return View(user);
                }
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
           }
            return View(user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLoginViewModel userLogin)
        {
            if(ModelState.IsValid)
            {
                var user = db.Users.Where(u => u.UserName == userLogin.Username).FirstOrDefault();
                if(user != null)
                {
                    if(user.Password == userLogin.Password)
                    {
                        var newsession = new UserSession()
                        {
                            UserID = user.UserID,
                            Username = user.UserName
                        };
                        this.Session["ValidSession"] = newsession;
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.InvalidLogin = true;
                        userLogin.Password = null;
                        return View(userLogin);
                    }
                }
            }
            return View(userLogin);
        }

        [HttpGet]
        public ActionResult LoggedIn()
        {
            if (Session["ValidSession"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            this.Session["ValidateSession"] = null;
            return RedirectToAction("Login");
        }
    }
}