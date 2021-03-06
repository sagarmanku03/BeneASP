﻿// <auto-generated />
using System;
using AssignmentFour.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssignmentFour.Migrations
{
    [DbContext(typeof(AssignmentFourContext))]
    partial class AssignmentFourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssignmentFour.Models.Benefit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlanCode")
                        .HasColumnType("int");

                    b.Property<int>("StaffCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanCode");

                    b.HasIndex("StaffCode");

                    b.ToTable("Benefit");
                });

            modelBuilder.Entity("AssignmentFour.Models.Job", b =>
                {
                    b.Property<int>("JobCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffCode")
                        .HasColumnType("int");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.HasKey("JobCode");

                    b.HasIndex("StaffCode");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("AssignmentFour.Models.Plan", b =>
                {
                    b.Property<int>("PlanCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlanDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlanCode");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("AssignmentFour.Models.Staff", b =>
                {
                    b.Property<int>("StaffCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffCode");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("AssignmentFour.Models.Benefit", b =>
                {
                    b.HasOne("AssignmentFour.Models.Plan", "Plan")
                        .WithMany("Benefits")
                        .HasForeignKey("PlanCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssignmentFour.Models.Staff", "Staff")
                        .WithMany("Benefits")
                        .HasForeignKey("StaffCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AssignmentFour.Models.Job", b =>
                {
                    b.HasOne("AssignmentFour.Models.Staff", "Staff")
                        .WithMany("Jobs")
                        .HasForeignKey("StaffCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
