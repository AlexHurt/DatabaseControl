using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseCore.Entity
{
    public class MedicalReport
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string PrescribedTreatment { get; set; }

        public int DoctorId { get; set; }

        public int PatientId { get; set; }

        public int AssignedCheckId { get; set; }

        [ForeignKey("DoctorId")]
        public User Doctor { get; set; }

        [ForeignKey("PatientId")]
        public User Patient { get; set; }

        [ForeignKey("AssignedCheckId")]
        public Check AssignedCheck { get; set; }
    }
}
