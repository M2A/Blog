﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Yara.Blog.Infrastructure.Routing
{
    public class RouteRegistrations
    {
        public static void Register(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}
