using System.Net.Mime;
using AstanaAir.Application.Common.Commands;
using AstanaAir.Application.Common.Dto;
using AstanaAir.Application.Common.Queries;
using AstanaAir.Application.Consts;
using AstanaAir.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AstanaAir.Web.Controllers;

/// <summary>
/// ������ ������� � ������.
/// </summary>
[ApiController]
[Route("[controller]")]
public class FlightsController : ControllerBase
{
    private readonly IMediator _mediator;

    public FlightsController(
        IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// ��������� ������ ������
    /// </summary>
    /// <response code="200">������� ������� ������ ���� ������</response>
    /// <response code="400">������ ���������</response>
    /// <response code="500">�� ����� ���������� ��������� ������</response>
    [Authorize]
    [HttpGet("/flights")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(GetAllFlightsDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllFlights(string? destination, string? origin)
    {
        var flights = await _mediator.Send(new GetAllFlightsQuery()
        {
            Destination = destination,
            Origin = origin
        });
        return Ok(flights);
    }

    /// <summary>
    /// ���������� ������ �����
    /// </summary>
    /// <response code="201">������� �������� ����� ����</response>
    /// <response code="400">������ ���������</response>
    /// <response code="500">�� ����� ���������� ��������� ������</response>
    [Authorize(Roles = nameof(RoleIds.Moderator))]
    [HttpPost("/flight")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateFlight(CreateFlightRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        var flights = await _mediator.Send(new CreateFlightCommand
        {
            Destination = request.Destination,
            Origin = request.Origin,
            Arrival = request.Arrival,
            Departure = request.Departure,
            Status = request.Status
        });
        return Created(string.Empty, flights);
    }

    /// <summary>
    /// �������������� �����
    /// </summary>
    /// <response code="200">������� ������� ������ �����</response>
    /// <response code="400">������ ���������</response>
    /// <response code="500">�� ����� ���������� ��������� ������</response>
    [Authorize(Roles = nameof(RoleIds.Moderator))]
    [HttpPatch("/flight")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> EditFlightStatus(EditFlightRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        await _mediator.Send(new EditFlightCommand()
        {
            FlightId = request.Id,
            Status = request.Status
        });
        return Ok();
    }
}