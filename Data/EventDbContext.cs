using Microsoft.EntityFrameworkCore;

namespace AccessibleEventTool.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=events.db");
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
