using MediatR;
using BookingRoomAPI.Infrastructure.Data;
using BookingRoomAPI.Core.Aggregates;
using System.Threading;
using System.Threading.Tasks;

namespace BookingRoomAPI.Application.CQRS.Commands
{
    public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand, bool>
    {
        private readonly IAppointmentRepository _repository;

        public CreateAppointmentHandler(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment = new Appointment
            {
                CustomerId = request.CustomerId,
                LocationId = request.LocationId,
                ServiceId = request.ServiceId,
                StaffId = request.StaffId,
                Name = request.Name,
                Email = request.Email,
                Contact = request.Contact,
                Date = request.Date,
                Time = request.Time,
                Notes = request.Notes,
                PaymentType = request.PaymentType,
                AppointmentStatus = request.AppointmentStatus,
                BusinessId = request.BusinessId,
                CreatedBy = request.CreatedBy
            };

            return await _repository.CreateAppointment(appointment);
        }
    }
}
