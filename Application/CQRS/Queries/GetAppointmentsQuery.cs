using MediatR;
using BookingRoomAPI.Core.Aggregates;
using System.Collections.Generic;

namespace BookingRoomAPI.Application.CQRS.Queries
{
    public class GetAppointmentsQuery : IRequest<List<Appointment>> { }
}
