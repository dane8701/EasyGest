using EASYGEST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EASYGEST.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users user)
        {
            using (DbRegisterModel db = new DbRegisterModel())
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    ModelState.AddModelError("", "Save done !");
                    return RedirectToAction("Login", "Account");
                }
                catch
                {
                    ModelState.AddModelError("", "champ required");
                }
            }
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public ActionResult Login(Users user)
        {
            if (ModelState.IsValid)
            {
                using (DbRegisterModel db = new DbRegisterModel())
                {
                    var listUser = db.Users.FirstOrDefault(a => a.Email == user.Email && a.Password == user.Password);
                    if (listUser != null)
                    {
                        //return View(listUser);
                        return RedirectToAction("Home", "Home");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            return RedirectToAction("Login", "Account");
        }
    }
}