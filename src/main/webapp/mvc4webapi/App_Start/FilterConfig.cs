using System.Web.Mvc;

namespace Itera.NDC2013.TCOD.Web.mvc4webapi.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}