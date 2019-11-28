using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class Message
    {
        public int Id { get; set; }

        public int FromUserId { get; set; }

        public int ToUserId { get; set; }

        public DateTime Time { get; set; }

        public string Text { get; set; }

        [ForeignKey("FromUserId")]
        public User FromUser { get; set; }

        [ForeignKey("ToUserId")]
        public User ToUser { get; set; }

    }
}