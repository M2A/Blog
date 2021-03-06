﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Yara.Blog.Infrastructure.Routing;

namespace Yara.Blog.Web.FrontEnd
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            //RouteRegistrations.Register(routes);
        }

        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            //Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
//        public class MVC_EF_CF_DBInitializer :
//            DropCreateDatabaseIfModelChanges<MVC_EF_CF_DB>
//        {
//            protected override void Seed(MVC_EF_CF_DB context)
//            {
//                base.Seed(context);
//                string temp = @"گفته شد که به قسمت دریافت شماره مراجعه کنید. مراجعه شد، گفتند برو پرونده‌ات را بگیر بیار. رفتم زیر زمین، گفت که ما اینطوری پرونده نمی‌دیم! برو فرمش رو هم پر کن بیار. مراجعه شد به کارمند مربوطه، ایشان پس از مشورت با سایر همکاران به این نتیجه رسیدند که در این مرحله نیازی به مراجعه به زیر زمین نبوده! و باید به قسمت ثبت نام مجدد مراجعه کنید! چشم!
//اینجا هم مجددا فرم پر شد،‌ارجاع داده شده به معاون قسمت، امضاء کرد گفت برو دبیرخانه شماره بگیر. شماره گرفته شده بعد مجددا به همان قسمت ثبت نام مراجعه کردم، گفتند برو پرونده‌ات را از زیر زمین بگیر بیار! بعد از آوردن پرونده، ارجاع شد به صورت دستی به یک قسمت دیگر که سوابق وارد سیستم شود (هنوز نشده بود!). بعد از ثبت (نیم ساعت یا بیشتر ...)، مجددا به همان قسمت ثبت نام مراجعه کردم، گفت حالا برو یک شماره بگیر بیار. شماره گرفته شد از قسمتی دیگر و مراجعه مجدد به قسمت ثبت نام، یک نامه دیگر تهیه کرد، به سه نفر دیگر + دبیرخانه برای امضاء و شماره گرفتن ارجاع داده شد. اینجا تمام شد. بعد این موارد ارجاع شد به قسمت دیگری از شهر برای دریافت قبض پرداخت بیمه.";
//                context.authors.Add(new author()
//                {
//                    authorID = 2,
//                    enrollmentDate = DateTime.Now,
//                    firstName = "Person1",
//                    lastName = "lastName"
//                });
//                context.authors.Add(new author()
//                {
//                    authorID = 3,
//                    enrollmentDate = DateTime.Now,
//                    firstName = "Person2",
//                    lastName = "lastName1"
//                });
//                context.authors.Add(new author()
//                {
//                    authorID = 4,
//                    enrollmentDate = DateTime.Now,
//                    firstName = "Person3",
//                    lastName = "lastName2"
//                });
//                context.posts.Add(new post() { 
//                    postID = 1, 
//                    Title="post01",
//                      Created = DateTime.Now,
//                       authorID = 2,
//                        Text = temp
//                });
//                context.posts.Add(new post()
//                {
//                    postID = 2,
//                    Title = "post02",
//                    Created = DateTime.Now,
//                    authorID = 3,
//                    Text = temp
//                });
//                context.posts.Add(new post()
//                {
//                    postID = 3,
//                    Title = "post03",
//                    Created = DateTime.Now,
//                    authorID = 4,
//                    Text = temp
//                });
//                context.SaveChanges();
//            }
//        }
    }
}