using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using AstanaAir.Application.Common.Commands;
using MediatR;
using AstanaAir.Application.Common.Queries;
using AstanaAir.Domain.Enum;
using AstanaAir.Domain.Models;

namespace AstanaAir.Controllers;

/// <summary>
/// Методы доступа к рейсам.
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
    /// Получение списка рейсов
    /// </summary>
    /// <response code="200">Успешно получен список всех рейсов</response>
    /// <response code="400">Ошибка валидации</response>
    /// <response code="500">Во время выполнения произошла ошибка</response>
    [HttpGet("/flights")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(GetAllFlightsDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllFlights(string origin, string destination)
    {
        var flights = await _mediator.Send(new GetAllFlightsQuery()
        {
            Destination = destination,
            Origin = origin
        });
        return Ok(flights);
    }

    /// <summary>
    /// Добавление нового рейса
    /// </summary>
    /// <response code="200">Успешно добавлен новый рейс</response>
    /// <response code="400">Ошибка валидации</response>
    /// <response code="500">Во время выполнения произошла ошибка</response>
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
    /// Редактирование рейса
    /// </summary>
    /// <response code="200">Успешно изменен статус рейса</response>
    /// <response code="400">Ошибка валидации</response>
    /// <response code="500">Во время выполнения произошла ошибка</response>
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