using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Configuration;
using System.Web.Http;

namespace Itera.Labs.ContinousDelivery.OctopusDemo.mvc4webapi.Controllers
{
    public class VersionController : ApiController
    {
        public string Get()
        {
            return Assembly.GetAssembly(typeof(WebApiApplication)).GetName().Version.ToString();
        }
    }
}
