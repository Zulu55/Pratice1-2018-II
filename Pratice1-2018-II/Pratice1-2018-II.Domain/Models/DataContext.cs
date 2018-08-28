namespace Pratice1_2018_II.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public DbSet<Animal> Animals { get; set; }

        public DbSet<Census> Census { get; set; }

        public DbSet<Patient> Patients { get; set; }
    }
}