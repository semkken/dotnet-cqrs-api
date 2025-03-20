using BookingRoomAPI.Core.Aggregates;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingRoomAPI.Infrastructure.Data
{
    public interface IAppointmentRepository
    {
        Task<bool> CreateAppointment(Appointment appointment);
        Task<List<Appointment>> GetAppointments();
    }
}
