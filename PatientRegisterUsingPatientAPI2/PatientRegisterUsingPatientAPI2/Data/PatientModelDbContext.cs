using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PatientRegisterUsingPatientAPI2.Models;

namespace PatientRegisterUsingPatientAPI2.Data
{
    public class PatientModelDbContext : DbContext  
    {
        public PatientModelDbContext(DbContextOptions options) : base(options)
        {

        }

        //public DbSet<PatientInformation> PatientInformations { get; set; }
        public virtual DbSet<Disease> Disease { get; set; }
        public virtual DbSet<NCD> NCD { get; set; }
        public virtual DbSet<Allergies> Allergies { get; set; }

        /*public virtual DbSet<PatientModel> PatientModel { get; set; }
        public virtual DbSet<Disease> Disease { get; set; }
        public virtual DbSet<NCD> NCD { get; set; }
        public virtual DbSet<Allergies> Allergies { get; set; }
        public virtual DbSet<NCD_details> NCD_deatils { get; set; }
        public virtual DbSet<Allergies_details> Allergies_details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<NCD_details>(entity =>
            {
                entity.HasOne(d => d.NCD)
                .WithMany(p => p.NCD_details)
                .HasForeignKey(d => d.NCDId)
                .OnDelete(DeleteBehavior.ClientSetNull);


                entity.HasOne(d => d.PatientModel)
                .WithMany(p => p.NCD_details)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            });

            modelBuilder.Entity<Allergies_details>(entity =>
            {
                entity.HasOne(d => d.Allergies)
                .WithMany(p => p.Allergies_details)
                .HasForeignKey(d => d.AllergiesId)
                .OnDelete(DeleteBehavior.ClientSetNull);


                entity.HasOne(d => d.PatientModel)
                .WithMany(p => p.Allergies_details)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            });

        }

        */


    }
}

