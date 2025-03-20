using BookingRoomAPI.Core.Aggregates;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingRoomAPI.Infrastructure.Data
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly List<Appointment> _appointments = new();

        public async Task<bool> CreateAppointment(Appointment appointment)
        {
            _appointments.Add(appointment);
            return await Task.FromResult(true);
        }

        public async Task<List<Appointment>> GetAppointments()
        {
            return await Task.FromResult(_appointments.ToList());
        }
    }
}
