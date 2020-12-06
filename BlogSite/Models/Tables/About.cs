using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSite.Models.Tables
{
    public class About
    {
        [Key]
        public int ID { get; set; }

        public string  ImgUrl { get; set; }
        [AllowHtml]
        public string Statement { get; set; }

    }
}