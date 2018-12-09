using PeakItMvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PeakItMvcApp.Infrastructure
{
    public class EventContext : DbContext 
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {            
        }

        public DbSet<Event> Event { get; set; }
    }
}