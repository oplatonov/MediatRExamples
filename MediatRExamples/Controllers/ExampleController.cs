using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExamples.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    private readonly IMediator _mediator;

    public ExampleController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    [Route("[action]")]
    public IActionResult Get()
    {
        return Ok();
    }
}