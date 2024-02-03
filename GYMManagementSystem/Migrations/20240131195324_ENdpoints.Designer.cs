﻿// <auto-generated />
using System;
using GYMManagementSystem.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GYMManagementSystem.Migrations
{
    [DbContext(typeof(GYMManagementSystemDbContext))]
    [Migration("20240131195324_ENdpoints")]
    partial class ENdpoints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.CoachTrainingCourse", b =>
                {
                    b.Property<int>("CoachTrainingCourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CoachPersonID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(302));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("TrainingCourseID")
                        .HasColumnType("int");

                    b.HasKey("CoachTrainingCourseID");

                    b.HasIndex("CoachPersonID");

                    b.HasIndex("TrainingCourseID");

                    b.ToTable("CoachTrainingCourse", (string)null);
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(1824));

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("NameInArabic")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("NameInEnglish")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasDefaultValue("Training and Observing");

                    b.HasKey("DepartmentID");

                    b.ToTable("Department", null, t =>
                        {
                            t.HasCheckConstraint("CH_Department_NameInArabic", "LENGTH(NameInArabic) >= 4");

                            t.HasCheckConstraint("CH_Department_NameInEnglish", "LENGTH(NameInEnglish) >= 4");
                        });
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Certifications")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 1, 31, 22, 53, 24, 392, DateTimeKind.Local).AddTicks(7832));

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(true)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("HealthStatus")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasDefaultValue("Uninfected");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(true)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<float>("Salary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(260f);

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SubscriptionID")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<int>("genderType")
                        .HasColumnType("int");

                    b.Property<int>("personType")
                        .HasColumnType("int");

                    b.HasKey("PersonID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NationalID")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.HasIndex("SubscriptionID");

                    b.ToTable("Person", null, t =>
                        {
                            t.HasCheckConstraint("CH_Person_Email", " Email LIKE '%@%.com'");

                            t.HasCheckConstraint("CH_Person_FullName", "LENGTH(FullName) >= 3");

                            t.HasCheckConstraint("CH_Person_PassWord", "PassWord LIKE '[1-9]'");

                            t.HasCheckConstraint("CH_Person_PhoneNumber", "PhoneNumber LIKE '009627________'");

                            t.HasCheckConstraint("CH_Person_StartDate", "EndDate > StartDate AND StartDate > sysdate() AND EndDate > sysdate()");
                        });
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.Subscription", b =>
                {
                    b.Property<int>("SubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(2271));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("varchar(25)");

                    b.Property<int>("DurationInDays")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("MaxNumberOfVisits")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(15f);

                    b.Property<int>("SubscriptionStatus")
                        .HasColumnType("int");

                    b.Property<int>("TrainingHoursInDay")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionID");

                    b.ToTable("Subscription", (string)null);
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.TrainingCourse", b =>
                {
                    b.Property<int>("TrainingCourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(4015));

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("intensityLevel")
                        .HasColumnType("int");

                    b.HasKey("TrainingCourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("TrainingCourse", (string)null);
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.TrainingCourseSubscription", b =>
                {
                    b.Property<int>("TrainingCourseSubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 1, 31, 22, 53, 24, 393, DateTimeKind.Local).AddTicks(6055));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<int>("SubscriptionID")
                        .HasColumnType("int");

                    b.Property<int>("TrainingCourseID")
                        .HasColumnType("int");

                    b.HasKey("TrainingCourseSubscriptionID");

                    b.HasIndex("SubscriptionID");

                    b.HasIndex("TrainingCourseID");

                    b.ToTable("TrainingCourseSubscription", (string)null);
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.CoachTrainingCourse", b =>
                {
                    b.HasOne("GYMManagementSystem.Models.Entities.Person", "Coach")
                        .WithMany("Course")
                        .HasForeignKey("CoachPersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GYMManagementSystem.Models.Entities.TrainingCourse", "TrainingCourse")
                        .WithMany("Coach")
                        .HasForeignKey("TrainingCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("TrainingCourse");
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.Person", b =>
                {
                    b.HasOne("GYMManagementSystem.Models.Entities.Department", "Department")
                        .WithMany("People")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GYMManagementSystem.Models.Entities.Subscription", "Subscription")
                        .WithMany("Client")
                        .HasForeignKey("SubscriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.TrainingCourse", b =>
                {
                    b.HasOne("GYMManagementSystem.Models.Entities.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.TrainingCourseSubscription", b =>
                {
                    b.HasOne("GYMManagementSystem.Models.Entities.Subscription", "Subscription")
                        .WithMany("TrainingCourseSubscription")
                        .HasForeignKey("SubscriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GYMManagementSystem.Models.Entities.TrainingCourse", "TrainingCourse")
                        .WithMany("TrainingCourseSubscription")
                        .HasForeignKey("TrainingCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");

                    b.Navigation("TrainingCourse");
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("People");
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.Person", b =>
                {
                    b.Navigation("Course");
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.Subscription", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("TrainingCourseSubscription");
                });

            modelBuilder.Entity("GYMManagementSystem.Models.Entities.TrainingCourse", b =>
                {
                    b.Navigation("Coach");

                    b.Navigation("TrainingCourseSubscription");
                });
#pragma warning restore 612, 618
        }
    }
}