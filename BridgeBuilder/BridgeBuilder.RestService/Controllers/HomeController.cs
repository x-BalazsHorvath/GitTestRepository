using System.Web.Http;

namespace BridgeBuilder.RestService.Controllers
{
    public class HomeController: ApiController
    {
        public IHttpActionResult GetNameList()
        {
            return Ok();
        }
    }
}
