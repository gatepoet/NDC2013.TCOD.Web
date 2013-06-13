using System.Web.Http;

namespace Itera.NDC2013.TCOD.Web.mvc4webapi.Controllers
{
    public class VersionController : ApiController
    {
        public string Get()
        {
            return WebApiApplication.Version;
        }
    }
}
