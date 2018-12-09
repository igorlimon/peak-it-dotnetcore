using System;

namespace PeakItMvcApp.Models
{
    public class Event
    {
        public long EventId { get; set; }

        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

        public int Capacity { get; set; }

        public int NumberOfRegistrations { get; set; }
    }
}