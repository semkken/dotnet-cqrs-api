namespace BookingRoomAPI.Core.Aggregates
{
    public class Appointment
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int LocationId { get; set; }
        public int ServiceId { get; set; }
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Notes { get; set; }
        public string PaymentType { get; set; }
        public string AppointmentStatus { get; set; }
        public int BusinessId { get; set; }
        public int CreatedBy { get; set; }
    }
}
