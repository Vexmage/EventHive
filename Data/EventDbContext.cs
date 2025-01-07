using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace AccessibleEventTool.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Resolve the full database path in a reliable location
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "events.db");

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source={databasePath}");
            }

            // Log the full database path
            Console.WriteLine($"Database Path: {databasePath}");
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            Console.WriteLine("Applying seed data...");
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Name = "Annual Tech Conference",
                    Description = "A conference discussing the latest in technology.",
                    Date = DateTime.Now.AddDays(10),
                    Location = "Tech Hall, Silicon Valley"
                },
                new Event
                {
                    Id = 2,
                    Name = "Community Cleanup Drive",
                    Description = "Join us for a community-wide cleanup effort.",
                    Date = DateTime.Now.AddDays(20),
                    Location = "Central Park"
                }
            );
        }
    }

    public class Event
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime Date { get; set; }
        public required string Location { get; set; }
    }
}
