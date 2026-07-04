using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new string[]
        {
            "Value 1",
            "Value 2",
            "Value 3"
        });
    }

    [HttpPost]
    public IActionResult Post(string value)
    {
        return Ok($"Received: {value}");
    }

    [HttpPut]
    public IActionResult Put(int id, string value)
    {
        return Ok($"Updated {id} with {value}");
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        return Ok($"Deleted {id}");
    }
}