using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using AstanaAir.Application.Common.Commands;
using MediatR;
using AstanaAir.Application.Common.Queries;
using AstanaAir.Application.Consts;
using AstanaAir.Domain.Enum;
using AstanaAir.Domain.Models;
using Microsoft.AspNetCore.Authorization;

namespace AstanaAir.Controllers;

/// <summary>
/// ������ ������� � ������.
/// </summary>
[ApiController]
[Route("[controller]")]
public class FlightsController : ControllerBase
{
    private readonly ILogger<FlightsController> _logger;
    private readonly IMediator _mediator;

    public FlightsController(
        ILogger<FlightsController> logger,
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
    [Authorize]
    [HttpGet("/flights")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(GetAllFlightsDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllFlights(string? origin, string? destination)
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
    [HttpPost("/flights")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateFlight(CreateFlightRequest request)
    {
        var flights = await _mediator.Send(new CreateFlightCommand()
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
    [HttpPatch("/flights/{id:int}")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateFlightStatus(int id, Status status)
    {
        await _mediator.Send(new EditFlightCommand()
        {
            FlightId = id,
            Status = status
        });
        return Ok();
    }
}