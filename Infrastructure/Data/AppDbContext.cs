using Microsoft.EntityFrameworkCore;
using BookingRoomAPI.Core.Aggregates;

namespace BookingRoomAPI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
