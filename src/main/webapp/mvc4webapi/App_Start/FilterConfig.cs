using System.Web.Mvc;

namespace Itera.Labs.ContinousDelivery.OctopusDemo.mvc4webapi.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}