using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class UserDocument
    {
        public int Id { get; set; }

        public int DocumentId { get; set; }

        public int UserId { get; set; }

        [ForeignKey("DocumentId")]
        public Document Document { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
