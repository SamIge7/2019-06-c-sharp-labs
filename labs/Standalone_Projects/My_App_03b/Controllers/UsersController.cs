using My_App_03b.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_App_03b.Controllers
{
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();
        private UserSession userSession;

        // GET: Users
        public ActionResult Index()
        {
            if (this.Session["ValidateUserSession"] != null)
            {
                userSession = this.Session["ValidateUserSession"] as UserSession;
                if ((userSession.UserName != null) && (userSession.LastActiveClick.Subtract(DateTime.UtcNow).TotalMinutes <= 1))
                {

                    return View(db.Users.ToList());
                }
            }
            ViewBag.MustLoginToViewUsers = true;
            return View("Login");
            
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
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

        // getting blank page
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        // posting form data from page back into database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Username, Password")] UserLoginViewModel user)
        {
            if(ModelState.IsValid)
            {
                var usr = db.Users.Where(u => u.Username == user.Username).FirstOrDefault();

                if (usr != null)
                {
                    if (usr.Password == user.Password)
                    {
                        var session = new UserSession()
                        {
                            UserId = usr.UserID,
                            UserName = usr.Username,
                            LastActiveClick = DateTime.UtcNow
                        };
                        this.Session["ValidateSession"] = session;
                        return RedirectToAction("LoggedIn");
                    }
                    else
                    {
                        ViewBag.InvalidPassword = true;
                        user.Password = null;
                        return View(user);
                    }
                }
                else
                {
                    // username invalid
                    ViewBag.UserFieldIsNull = "none";
                    return RedirectToAction("Login");
                }
                

            }
            return View(user);
        }


        // get blank page after successful login
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

        public ActionResult LogOut()
        {
            this.Session["ValidateUserSession"] = null;
            return RedirectToAction("Login");
        }
    }
}