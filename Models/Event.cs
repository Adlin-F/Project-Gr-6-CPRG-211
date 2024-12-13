using System;

public class Event
{
    public int EventId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int VenueId { get; set; }

    // Navigation property
    public Venue Venue { get; set; }
}
