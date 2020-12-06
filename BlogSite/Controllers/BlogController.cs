using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models.Tables;

namespace BlogSite.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogComments blogComments = new BlogComments();
        public ActionResult Index()
        {
            blogComments.blogs = context.Blogs.Take(6).ToList();
            blogComments.blogs1 = context.Blogs.OrderByDescending(s => s.Date).Take(6   ).ToList();

           
            return View(blogComments);
        }
        [HttpGet]
        public ActionResult BlogDetail(int id)
        {
            blogComments.blogs = context.Blogs.Where(x => x.ID == id).ToList();
            blogComments.comments = context.Comments.Where(x => x.BlogID == id).ToList();
            
            return View(blogComments);
        }
        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Comment(Comments comments)
        {
             context.Comments.Add(comments);
             context.SaveChanges();
            return PartialView();


          
        }

    }
}