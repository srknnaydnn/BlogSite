using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models.Tables;

namespace BlogSite.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context context = new Context(); 
        public ActionResult Index()
        {
            var blog = context.Blogs.ToList();
            return View(blog);
        }
        [HttpGet]
        public ActionResult BlogAdd()
        {
            return View();
        }
        [HttpPost]

        public ActionResult BlogAdd(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDelete(int id )
        {
            var find = context.Blogs.Find(id);
            context.Blogs.Remove(find);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
       public ActionResult BlogFind(int id)
        {
            var find = context.Blogs.Find(id);
            if (find == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("BlogFind",find);

            }
           
        }
        public ActionResult BlogUpdate(Blog blog)
        {
            var find = context.Blogs.SingleOrDefault(x=>x.ID==blog.ID);
             if(find != null)
            {
                find.Date = blog.Date;
                find.ImgUrl = blog.ImgUrl;
                find.Header = blog.Header;
                find.Statement = blog.Statement;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
         
            
        }

        public ActionResult Address(Adress adress)
        {
            context.Adresses.Add(adress);
            context.SaveChanges();
            return View();
        }
        public ActionResult About(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return View();
        }
    }
}