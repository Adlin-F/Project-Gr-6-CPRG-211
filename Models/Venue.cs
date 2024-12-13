public class Venue
{
    public int VenueId { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Location { get; set; }

    // Navigation property
    public ICollection<Event> Events { get; set; }
}
