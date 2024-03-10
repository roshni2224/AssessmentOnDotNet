using Microsoft.EntityFrameworkCore;
using PatientAPI2.Models;

namespace PatientAPI2.Data
{
    public class PatientsAPIDbContext : DbContext
    {
        public PatientsAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}
