using System.Web;
using System.Web.Mvc;

namespace Pluralsight_OdeToFoodb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
