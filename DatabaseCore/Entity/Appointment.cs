using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public enum AppointmentStatus
    {
        Awaiting,
        InProgress,
        Cancelled
    }

    public class Appointment
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public AppointmentStatus Status { get; set; }

        public int RoomNumber { get; set; }

        public int TimeSlotId { get; set; }

        [ForeignKey("TimeSlotId")]
        public TimeSlot TimeSlot { get; set; }     

        public int AssignedCheckId { get; set; }

        [ForeignKey("AssignedCheckId")]
        public Check AssignedCheck { get; set; }
    }
}
