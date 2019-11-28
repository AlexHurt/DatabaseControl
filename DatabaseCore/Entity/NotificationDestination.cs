using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class NotificationDestination
    {
        public int Id { get; set; }

        public int NotificationId { get; set; }

        public int IntendedForUserId { get; set; }

        public bool IsViewed { get; set; }

        [ForeignKey("NotificationId")]
        public Notification Notification { get; set; }

        [ForeignKey("IntendedForUserId")]
        public User IntendedFor { get; set; }
    }
}
