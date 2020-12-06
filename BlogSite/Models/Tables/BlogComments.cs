using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models.Tables
{
    public class BlogComments
    {
        public IEnumerable<Blog> blogs { get; set; }
        public IEnumerable<Comments> comments { get; set; }
        public IEnumerable<Blog> blogs1 { get; set; }
    }
}