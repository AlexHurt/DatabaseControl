namespace DatabaseCore.Entity
{
    public enum UserRole
    {
        Patient,
        Administration,
        Nurse,
        Doctor,
        Receptionist
    }

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public UserRole Role { get;set; }

        public string PasswordHash { get; set; }

        public int Salary { get; set; }

        public string Email { get; set; }
    }
}
