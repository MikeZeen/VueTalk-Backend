using VueTalk.Application.Common.Errors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace VueTalk.API.Controllers;

public class ErrorsController : ApiController
{
    [Route("/error")]
    public IActionResult Error() 
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem();
    }
}