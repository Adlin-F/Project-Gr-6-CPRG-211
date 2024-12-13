public class Booking
{
    public int BookingId { get; set; }
    public int EventId { get; set; }
    public int AttendeeId { get; set; }
    public DateTime BookingDate { get; set; }

    // Navigation properties
    public Event Event { get; set; }
    public Attendee Attendee { get; set; }
}
