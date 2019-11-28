using System;

namespace DatabaseCore.Entity
{
    public class TimeSlot
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}