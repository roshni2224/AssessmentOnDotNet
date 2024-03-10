﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientRegisterUsingPatientAPI2.Data;

#nullable disable

namespace PatientRegisterUsingPatientAPI2.Migrations
{
    [DbContext(typeof(PatientModelDbContext))]
    [Migration("20240310165518_another migration")]
    partial class anothermigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PatientRegisterUsingPatientAPI2.Models.Allergies", b =>
                {
                    b.Property<int>("AllergiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllergiesId"));

                    b.Property<int>("AllergiesName")
                        .HasColumnType("int");

                    b.HasKey("AllergiesId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("PatientRegisterUsingPatientAPI2.Models.Disease", b =>
                {
                    b.Property<int>("DiseaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiseaseId"));

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiseaseId");

                    b.ToTable("Disease");
                });

            modelBuilder.Entity("PatientRegisterUsingPatientAPI2.Models.NCD", b =>
                {
                    b.Property<int>("NCDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NCDId"));

                    b.Property<string>("NCDName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NCDId");

                    b.ToTable("NCD");
                });
#pragma warning restore 612, 618
        }
    }
}