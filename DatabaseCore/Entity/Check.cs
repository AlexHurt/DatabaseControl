using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class Check
    {
        public int Id { get; set; }

        public int Amount { get; set; }

        public bool IsPaid { get; set; }

        public int PayerId { get; set; }

        [ForeignKey("PayerId")]
        public User Payer { get; set; }
    }
}
