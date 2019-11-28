using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class UserAppointment
    {
        public int Id { get; set; }

        public int AppointmentId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
