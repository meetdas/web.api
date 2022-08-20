using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web.Api.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("Name")]
        [HttpGet]
        public string GetName()
        {
            return "This is Nato";
        }

        [Route("[action]")]
        [HttpGet]
        public string GetFullName()
        {
            return "Nato Das";
        }
    }
}
