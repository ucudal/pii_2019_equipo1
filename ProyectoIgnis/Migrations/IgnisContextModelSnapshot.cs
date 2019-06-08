﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoIgnis.Models;

namespace ProyectoIgnis.Migrations
{
    [DbContext(typeof(IgnisContext))]
    partial class IgnisContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("ProyectoIgnis.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("MailAdress");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ProyectoIgnis.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Client");

                    b.Property<string>("Description");

                    b.Property<int>("HourLoad");

                    b.Property<string>("Level");

                    b.Property<string>("Role");

                    b.HasKey("ID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("ProyectoIgnis.Models.ProjectAllocated", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Client");

                    b.Property<string>("Description");

                    b.Property<int>("HourLoad");

                    b.Property<string>("Level");

                    b.Property<string>("Role");

                    b.Property<int?>("TechnicianID");

                    b.HasKey("ID");

                    b.HasIndex("TechnicianID");

                    b.ToTable("ProjectAllocated");
                });

            modelBuilder.Entity("ProyectoIgnis.Models.Technician", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("Level");

                    b.Property<string>("MailAdress");

                    b.Property<string>("Name");

                    b.Property<string>("Role");

                    b.HasKey("ID");

                    b.ToTable("Technician");
                });

            modelBuilder.Entity("ProyectoIgnis.Models.ProjectAllocated", b =>
                {
                    b.HasOne("ProyectoIgnis.Models.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianID");
                });
#pragma warning restore 612, 618
        }
    }
}
