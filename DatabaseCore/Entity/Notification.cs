using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class Notification
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedByUserId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public User CreatedBy { get; set; }
    }
}
