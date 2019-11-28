namespace DatabaseCore.Entity
{
    public enum DocumentType
    {
        SocialSecurityCard,
        Passport,
        DrivingLicense,
        HealthInsurance
    }

    public class Document
    {
        public int Id { get; set; }

        public DocumentType Type { get; set; }

        public string DocumentId { get; set; }

        public string File { get; set; }
    }
}