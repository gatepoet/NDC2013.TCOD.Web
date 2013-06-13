using System.Configuration;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Diagnostics;
using Itera.NDC2013.TCOD.Web.mvc4webapi.App_Start;

namespace Itera.NDC2013.TCOD.Web.mvc4webapi
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801


    public class WebApiApplication : System.Web.HttpApplication
    {
        public static string Version
        {
            get
            {
                var assembly = Assembly.GetAssembly(typeof (WebApiApplication));
                var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                return versionInfo.ProductVersion;
            }
        }

        public static string Environment
        {
            get
            {
                return ConfigurationManager.AppSettings["Environment"];
            }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}