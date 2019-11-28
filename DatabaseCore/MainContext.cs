using DatabaseCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCore
{
    public sealed class MainContext : DbContext
    {
        public MainContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5431;Database=mainDB;Username=postgres;Password=23081975");
        }

        public DbSet<Appointment> Appointment { get; set; }

        public DbSet<Check> CheckTb { get; set; }

        public DbSet<Document> DocumentTb { get; set; }

        public DbSet<DocumentReport> DocumentReport { get; set; }

        public DbSet<MedicalReport> MedicalReport { get; set; }
        
        public DbSet<MedicineJournal> MedicineJournal { get; set; }

        public DbSet<MedicineStock> MedicineStock { get; set; }

        public DbSet<Message> MessageTb { get; set; }

        public DbSet<Notice> NoticeTb { get; set; }

        public DbSet<Notification> Notification { get; set; }

        public DbSet<TimeSlot> TimeSlot { get; set; }

        public DbSet<User> UserTb { get; set; }

        public DbSet<UserAppointment> UserAppointment { get; set; }

        public DbSet<UserDocument> UserDocument { get; set; }
    }
}