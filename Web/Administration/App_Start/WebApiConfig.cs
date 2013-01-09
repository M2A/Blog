using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

<<<<<<< HEAD
namespace Administration
=======
namespace Yara.Blog.Web.Administration
>>>>>>> 0359986b98a1f3760886b0d44ce0437ea1f0e886
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
