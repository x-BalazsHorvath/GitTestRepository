using System.Web.Http;

namespace BridgeBuilder.RestService.Controllers
{
    public class HomeController: ApiController
    {
        /// <summary>
        /// Updated code
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult GetNameList()
        {
            return Ok();
        }
    }
}
