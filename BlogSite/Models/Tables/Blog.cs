using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Models.Tables
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Header { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [AllowHtml]
        public string Statement { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Comments> Comments { get; set; }

    }
}