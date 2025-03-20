using MediatR;
using Microsoft.AspNetCore.Mvc;
using BookingRoomAPI.Application.CQRS.Commands;
using BookingRoomAPI.Application.CQRS.Queries;
using System.Threading.Tasks;

namespace BookingRoomAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppointmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAppointment([FromBody] CreateAppointmentCommand command)
        {
            var result = await _mediator.Send(command);
            return result ? Ok(new { message = "Appointment created successfully" }) : BadRequest(new { error = "Failed to create appointment" });
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetAppointments()
        {
            var result = await _mediator.Send(new GetAppointmentsQuery());
            return Ok(result);
        }
    }
}
