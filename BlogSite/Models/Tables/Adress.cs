using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSite.Models.Tables
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        public string OpenAdress { get; set; }
        public string Mail { get; set; }
        public string Telefone { get; set; }

    }
}