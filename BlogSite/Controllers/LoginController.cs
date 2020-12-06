using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BlogSite.Models.Tables;

namespace BlogSite.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if(result != null)
            {
                FormsAuthentication.SetAuthCookie(result.Username, false);
                Session["users"] = result.Username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.message = "*Kullanıcı Bilgileri Yalnış!";
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}