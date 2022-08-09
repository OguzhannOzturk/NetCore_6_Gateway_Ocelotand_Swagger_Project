using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult get()
    {
        return Ok(new List<string>{"Pen", "Book", "Eraser", "Sharpener", "Pencil Case", "Staple"});
    }
}