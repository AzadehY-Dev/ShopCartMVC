using ShopCart_MVC.Models;

namespace ShopCart_MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopCart_MVC.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopCart_MVC.Models.MyContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.Add(new Product()
                {
                    ProductTitle = "فلاسک چای",
                    Price = 1000,
                    ImageName = "1.jpg"
                });

                context.Products.Add(new Product()
                {
                    ProductTitle = "شارژر فندکی",
                    Price = 2400,
                    ImageName = "2.jpg"
                });

                context.Products.Add(new Product()
                {
                    ProductTitle = "ماشین لباسشوئی",
                    Price = 64500,
                    ImageName = "3.jpg"
                });

                context.Products.Add(new Product()
                {
                    ProductTitle = "ساعت مچی",
                    Price = 12000,
                    ImageName = "4.jpg"
                });

                context.Products.Add(new Product()
                {
                    ProductTitle = "چرخ گوشت",
                    Price = 87000,
                    ImageName = "5.jpg"
                });

                context.SaveChanges();
            }
        }
    }
}
