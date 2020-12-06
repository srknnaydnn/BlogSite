using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models.Tables;

namespace BlogSite.Controllers
{
    public class AboutController : Controller
    {
         Context context=new Context();

     
        // GET: About
        public ActionResult Index()
        {
            var about = context.Abouts.ToList();
            return View(about);
        }
    }
}