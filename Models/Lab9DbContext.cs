using MauiApp1.Models;
using Microsoft.EntityFrameworkCore;

public class Lab9DbContext(DbContextOptions<Lab9DbContext> options) : DbContext(options)
{

    public DbSet<Event> Events { get; set; }
    public DbSet<Venue> Venues { get; set; }
    public DbSet<Attendee> Attendees { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Book> Books { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Fluent API configurations (optional)
        modelBuilder.Entity<Event>()
            .HasOne(e => e.Venue)
            .WithMany(v => v.Events)
            .HasForeignKey(e => e.VenueId);
    }
}
