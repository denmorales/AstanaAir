using System.Net.Mime;
using AstanaAir.Application.Common.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AstanaAir.Web.Controllers;

/// <summary>
/// ������ �����������.
/// </summary>
[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly ILogger<AuthController> _logger;
    private readonly IMediator _mediator;

    public AuthController(
        ILogger<AuthController> logger,
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    /// <summary>
    /// ��������� ������ ������
    /// </summary>
    /// <response code="200">������� ������� ������ ���� ������</response>
    /// <response code="400">������ ���������</response>
    /// <response code="500">�� ����� ���������� ��������� ������</response>
    [HttpGet("/authorize")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(GetAllFlightsDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> Authorize(string userName, string Password)
    {
        //var flights = await _mediator.Send(new GetAllFlightsQuery()
        //{
        //    Destination = destination,
        //    Origin = origin
        //});
        return Ok();
    }
}