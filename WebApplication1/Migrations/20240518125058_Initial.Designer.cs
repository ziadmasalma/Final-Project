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
<<<<<<<< HEAD:WebApplication1/Migrations/20240525090101_initl.Designer.cs
    [Migration("20240525090101_initl")]
    partial class initl
========
    [Migration("20240518125058_Initial")]
    partial class Initial
>>>>>>>> 7b73e7e13205e0f55aaac371b67d77eca66868b7:WebApplication1/Migrations/20240518125058_Initial.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Table.EventEntity", b =>
                {
                    b.Property<int>("ActivityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityID"));

                    b.Property<string>("ActivityDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActivityExecutionTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConcilMemberID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateImplementationActivity")
                        .HasColumnType("datetime2");

                    b.Property<string>("EntityResponsibleActivity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationOfActivity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberParticipateActivity")
                        .HasColumnType("int");

                    b.HasKey("ActivityID");

                    b.HasIndex("ConcilMemberID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("WebApplication1.Table.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime2");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");
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

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("int");

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
                        .HasColumnType("int");

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

            modelBuilder.Entity("WebApplication1.Table.studentConcilMember", b =>
                {
                    b.Property<int>("ConcilMemberID")
                        .HasColumnType("int");

                    b.Property<string>("ConcilMemberName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntityResponsibleActivity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastSeen")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConcilMemberID");

                    b.ToTable("studentConcilMembers");
                });

            modelBuilder.Entity("WebApplication1.Table.EventEntity", b =>
                {
                    b.HasOne("WebApplication1.Table.studentConcilMember", "ConcilMember")
                        .WithMany("Events")
                        .HasForeignKey("ConcilMemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConcilMember");
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

            modelBuilder.Entity("WebApplication1.Table.Teacher", b =>
                {
                    b.Navigation("OfficeHours");
                });

            modelBuilder.Entity("WebApplication1.Table.studentConcilMember", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
