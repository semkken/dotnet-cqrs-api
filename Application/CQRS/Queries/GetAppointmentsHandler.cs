using MediatR;
using BookingRoomAPI.Infrastructure.Data;
using BookingRoomAPI.Core.Aggregates;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BookingRoomAPI.Application.CQRS.Queries
{
    public class GetAppointmentsHandler : IRequestHandler<GetAppointmentsQuery, List<Appointment>>
    {
        private readonly IAppointmentRepository _repository;

        public GetAppointmentsHandler(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Appointment>> Handle(GetAppointmentsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAppointments();
        }
    }
}
