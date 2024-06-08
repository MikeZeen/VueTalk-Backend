using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace VueTalk.API.Controllers;

[Route("[controller]")]
public class PostsController : ApiController
{
    [HttpGet]
    public IActionResult ListPosts()
    {
        return Ok(Array.Empty<string>());
    }
}