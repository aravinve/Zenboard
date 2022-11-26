using Microsoft.AspNetCore.Mvc;
using Zenboard.Common;

namespace Zenboard.Controllers;

[ApiController]
public class IssueController : ControllerBase
{
    [HttpGet(ApiRoutes.Issue.GetAll)]
    public IActionResult GetAll()
    {
        return Ok("Hello World");
    }
}