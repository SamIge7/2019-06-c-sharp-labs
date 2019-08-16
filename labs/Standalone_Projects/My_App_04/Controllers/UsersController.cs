using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using My_App_04.Models;

namespace My_App_04.Controllers
{
    public class UsersController : Controller
    {
        private UserContext db = new UserContext();
        public List<User> Users = new List<User>();
        public UserSession userSession;
        // GET: Users
        public ActionResult Index()
        {
            if (this.Session["ValidateSession"] != null)
            {
                userSession = this.Session["ValidateSession"] as UserSession;
                if (userSession.UserName != null)
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
        public ActionResult LogOut()
        {
            this.Session["ValidateSession"] = null;
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Username, Password")] UserLoginView userLoginView)
        {
            if(ModelState.IsValid)
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
                        return View("Login");
                    }
                }
                return RedirectToAction("Login");
                
            }
            return View(userLoginView);

        }

        [HttpGet]
        public ActionResult LoggedIn()
        {
            if(Session["ValidateSession"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,UserName,Password,FirstName,LastName")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
