﻿// <auto-generated />
using System;
using FitStudio_App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitStudio_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230119220132_secondMig")]
    partial class secondMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitStudio_App.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Intensity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WeekDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            Activity = "Fitness",
                            ClassName = "Kangoo Jumps",
                            EndTime = new DateTime(2022, 12, 12, 10, 50, 0, 0, DateTimeKind.Unspecified),
                            Intensity = "Medium",
                            StartTime = new DateTime(2022, 12, 12, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 0,
                            WeekDay = "Monday"
                        },
                        new
                        {
                            ClassId = 2,
                            Activity = "Cardio",
                            ClassName = "Real Ryder",
                            EndTime = new DateTime(2022, 12, 12, 11, 50, 0, 0, DateTimeKind.Unspecified),
                            Intensity = "Extreme",
                            StartTime = new DateTime(2022, 12, 12, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 0,
                            WeekDay = "Monday"
                        },
                        new
                        {
                            ClassId = 3,
                            Activity = "Fitness",
                            ClassName = "Kangoo Jumps",
                            EndTime = new DateTime(2022, 12, 12, 14, 50, 0, 0, DateTimeKind.Unspecified),
                            Intensity = "Medium",
                            StartTime = new DateTime(2022, 12, 12, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 0,
                            WeekDay = "Monday"
                        },
                        new
                        {
                            ClassId = 4,
                            Activity = "Fitness",
                            ClassName = "Kangoo Jumps",
                            EndTime = new DateTime(2022, 12, 13, 10, 50, 0, 0, DateTimeKind.Unspecified),
                            Intensity = "Medium",
                            StartTime = new DateTime(2022, 12, 13, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 0,
                            WeekDay = "Tuesday"
                        },
                        new
                        {
                            ClassId = 5,
                            Activity = "Cardio",
                            ClassName = "Real Ryder",
                            EndTime = new DateTime(2022, 12, 14, 10, 50, 0, 0, DateTimeKind.Unspecified),
                            Intensity = "Extreme",
                            StartTime = new DateTime(2022, 12, 14, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 0,
                            WeekDay = "Wednesday"
                        });
                });

            modelBuilder.Entity("FitStudio_App.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 2,
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Adi",
                            RoleId = 3,
                            Salary = 0.0
                        },
                        new
                        {
                            EmployeeId = 5,
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Andra",
                            RoleId = 3,
                            Salary = 0.0
                        },
                        new
                        {
                            EmployeeId = 1,
                            ClassId = 1,
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Anca",
                            RoleId = 4,
                            Salary = 0.0
                        },
                        new
                        {
                            EmployeeId = 3,
                            ClassId = 2,
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alex",
                            RoleId = 4,
                            Salary = 0.0
                        },
                        new
                        {
                            EmployeeId = 4,
                            ClassId = 4,
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Maria",
                            RoleId = 4,
                            Salary = 0.0
                        },
                        new
                        {
                            EmployeeId = 6,
                            ClassId = 3,
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cristian",
                            RoleId = 4,
                            Salary = 0.0
                        },
                        new
                        {
                            EmployeeId = 7,
                            ClassId = 5,
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lucian",
                            RoleId = 4,
                            Salary = 0.0
                        });
                });

            modelBuilder.Entity("FitStudio_App.Models.MembershipInfo", b =>
                {
                    b.Property<int>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipId"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("MembershipId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("MembershipInfos");
                });

            modelBuilder.Entity("FitStudio_App.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MembershipTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 19.989999999999998,
                            Type = "Bronze"
                        },
                        new
                        {
                            Id = 2,
                            Price = 34.990000000000002,
                            Type = "Silver"
                        },
                        new
                        {
                            Id = 3,
                            Price = 49.990000000000002,
                            Type = "Gold"
                        });
                });

            modelBuilder.Entity("FitStudio_App.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FitStudio_App.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Cash"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Card"
                        });
                });

            modelBuilder.Entity("FitStudio_App.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleType = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleType = "Client"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleType = "Receptionist"
                        },
                        new
                        {
                            RoleId = 4,
                            RoleType = "Trainer"
                        });
                });

            modelBuilder.Entity("FitStudio_App.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PaswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PaswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("PhoneNo")
                        .HasColumnType("int");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FitStudio_App.Models.MembershipInfo", b =>
                {
                    b.HasOne("FitStudio_App.Models.MembershipType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitStudio_App.Models.User", null)
                        .WithMany("MembershipInfos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("FitStudio_App.Models.Payment", b =>
                {
                    b.HasOne("FitStudio_App.Models.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("FitStudio_App.Models.User", b =>
                {
                    b.HasOne("FitStudio_App.Models.Class", null)
                        .WithMany("Users")
                        .HasForeignKey("ClassId");

                    b.HasOne("FitStudio_App.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FitStudio_App.Models.Class", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("FitStudio_App.Models.User", b =>
                {
                    b.Navigation("MembershipInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
