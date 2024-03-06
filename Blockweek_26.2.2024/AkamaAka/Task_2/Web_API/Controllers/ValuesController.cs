using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Values 1", "Values 2", "Values 3", "values4" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "The value is " + id;
        }
    }
}
