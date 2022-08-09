using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult get()
    {
        return Ok(new List<string>{"Kalem", "Kitap", "Silgi", "Kalemtraş", "kalemlik", "Zımba"});
    }
}