using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class DocumentReport
    {
        public int Id { get; set; }

        public int ReportId { get; set; }

        public int DocumentId { get; set; }

        [ForeignKey("ReportId")]
        public MedicalReport Report { get; set; }

        [ForeignKey("DocumentId")]
        public Document Document { get; set; }
    }
}