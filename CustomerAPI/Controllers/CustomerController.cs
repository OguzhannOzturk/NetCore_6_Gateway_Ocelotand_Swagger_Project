using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers;


[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new List<string>{"Maria Anders", "Ana Trujillo", "Antonio Moreno", "Thomas Hardy", "Christina Berglund", "Christina Berglund"});
    }
}