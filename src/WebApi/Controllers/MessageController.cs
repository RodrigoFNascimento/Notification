using Application.UseCases.Message.Responses;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly ILogger<MessageController> _logger;
    private readonly IMediator _mediator;

    public MessageController(ILogger<MessageController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetAllMessages")]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new Application.UseCases.Message.Queries.GetAllMessagesQuery(), CancellationToken.None);
        return Ok(result);
    }
}
