﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSite.Models.Tables
{
    public class Context:DbContext
    {
        public DbSet<About>  Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adress>  Adresses { get; set; }
        public DbSet<Blog>  Blogs { get; set; }
        public DbSet<Comments>  Comments { get; set; }
        public DbSet<Contact>  Contacts{ get; set; }
        public DbSet<Home>  Homes { get; set; }



    }
}