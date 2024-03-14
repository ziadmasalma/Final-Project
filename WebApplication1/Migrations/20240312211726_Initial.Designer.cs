﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240312211726_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Table.Event", b =>
                {
                    b.Property<int>("ActivityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityID"));

                    b.Property<string>("ActivityDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActivityExecutionTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateImplementationActivity")
                        .HasColumnType("datetime2");

                    b.Property<string>("EntityResponsibleActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationOfActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberParticipateActivity")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ActivityID");

                    b.HasIndex("StudentID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("WebApplication1.Table.OfficeHour", b =>
                {
                    b.Property<int>("OfficeHourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfficeHourId"));

                    b.Property<string>("BuildingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TeacherFreeDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TeacherFreeEndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TeacherFreeStartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("OfficeHourId");

                    b.HasIndex("TeacherId");

                    b.ToTable("OfficeHours");
                });

            modelBuilder.Entity("WebApplication1.Table.Probosal", b =>
                {
                    b.Property<int>("ProbosalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProbosalID"));

                    b.Property<string>("ProbosalDescribtion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetParty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProbosalID");

                    b.ToTable("Proposals");
                });

            modelBuilder.Entity("WebApplication1.Table.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityMajor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApplication1.Table.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Teachername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("WebApplication1.Table.Event", b =>
                {
                    b.HasOne("WebApplication1.Table.Student", "Student")
                        .WithMany("Events")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WebApplication1.Table.OfficeHour", b =>
                {
                    b.HasOne("WebApplication1.Table.Teacher", "Teacher")
                        .WithMany("OfficeHours")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("WebApplication1.Table.Student", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("WebApplication1.Table.Teacher", b =>
                {
                    b.Navigation("OfficeHours");
                });
#pragma warning restore 612, 618
        }
    }
}
