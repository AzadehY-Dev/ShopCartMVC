using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopCart_MVC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }


    }
}