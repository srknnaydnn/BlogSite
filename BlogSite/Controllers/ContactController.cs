using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models.Tables;

namespace BlogSite.Controllers
{
    public class ContactController : Controller
    {
        Context context = new Context();
        [HttpGet]
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            var result = context.Contacts.Add(contact);
            context.SaveChanges();
            if(result.NameSurname==null && result.Mail==null && result.Subject == null && result.Message == null)
            {
                ViewBag.message = "Boş Alanları Doldurun";
                return View();
            }
            else
            {
                return View();

            }



        }


        public PartialViewResult Adress()
        {
           var adress=context.Adresses.ToList();
            return PartialView(adress);
        }
    }
}