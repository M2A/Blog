using System.Web;
using System.Web.Mvc;

<<<<<<< HEAD
namespace Administration
=======
namespace Yara.Blog.Web.Administration
>>>>>>> 0359986b98a1f3760886b0d44ce0437ea1f0e886
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}