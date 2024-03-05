using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers;

[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Values 1", "Values2", "Values3", "Values4", "Values5" };
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"The value is {id}";
    }
}