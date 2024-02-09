using System.Net.Mime;
using AstanaAir.Application.Common.Commands;
using AstanaAir.Application.Common.Dto;
using AstanaAir.Domain.Models;
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
    private readonly IMediator _mediator;

    public AuthController(
        IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// ��������� ������ �����������
    /// </summary>
    /// <response code="200">������� ������� �����</response>
    /// <response code="400">������ ���������</response>
    /// <response code="500">�� ����� ���������� ��������� ������</response>
    [HttpPost("/authorize")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(GetAllFlightsDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> Authorize(AuthorizeRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var token = await _mediator.Send(new AuthorizeCommand()
        {
            Password = request.Password,
            UserName = request.UserName
        });
        return Ok(token);
    }
}