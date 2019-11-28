
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public enum ActionType
    {
        Add,
        Take,
        View
    }

    public class MedicineJournal
    {
        public int Id { get; set; }

        public DateTime ActionTime { get; set; }

        public ActionType ActionType { get; set; }

        public int? Amount { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
