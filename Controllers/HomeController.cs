using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopCart_MVC.Models;

namespace ShopCart_MVC.Controllers
{
    public class HomeController : Controller
    {
        MyContext db=new MyContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}