using Microsoft.AspNetCore.Mvc;

namespace BookAPI;

[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Values 1", "Values 2", "Values 3", "Values 4" };
    }

    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"The value is {id}";
    }
}