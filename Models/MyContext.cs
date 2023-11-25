using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopCart_MVC.Models
{
    public class MyContext:DbContext
    {
        public DbSet<Product> Products { get; set; }



    }
}