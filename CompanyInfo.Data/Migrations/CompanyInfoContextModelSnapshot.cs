﻿// <auto-generated />
using System;
using CompanyInfo.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyInfo.Data.Migrations
{
    [DbContext(typeof(CompanyInfoContext))]
    partial class CompanyInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CompanyInfo.Data.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MainOffice")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrganisationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Company1",
                            MainOffice = "Stockholm",
                            OrganisationNumber = "08-123456"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Company2",
                            MainOffice = "Oslo",
                            OrganisationNumber = "01-123456"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Company3",
                            MainOffice = "Helsinki",
                            OrganisationNumber = "12-456789"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Company4",
                            MainOffice = "Köpenhamn",
                            OrganisationNumber = "31-123456"
                        });
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int>("DepartamentNameID")
                        .HasColumnType("int");

                    b.Property<int?>("DepartamentsNameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyID");

                    b.HasIndex("DepartamentsNameId");

                    b.ToTable("Departaments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyID = 1,
                            DepartamentNameID = 1
                        },
                        new
                        {
                            Id = 2,
                            CompanyID = 1,
                            DepartamentNameID = 2
                        },
                        new
                        {
                            Id = 3,
                            CompanyID = 1,
                            DepartamentNameID = 3
                        },
                        new
                        {
                            Id = 4,
                            CompanyID = 1,
                            DepartamentNameID = 4
                        },
                        new
                        {
                            Id = 5,
                            CompanyID = 1,
                            DepartamentNameID = 5
                        },
                        new
                        {
                            Id = 6,
                            CompanyID = 1,
                            DepartamentNameID = 6
                        },
                        new
                        {
                            Id = 7,
                            CompanyID = 1,
                            DepartamentNameID = 7
                        },
                        new
                        {
                            Id = 8,
                            CompanyID = 1,
                            DepartamentNameID = 8
                        },
                        new
                        {
                            Id = 9,
                            CompanyID = 2,
                            DepartamentNameID = 1
                        },
                        new
                        {
                            Id = 10,
                            CompanyID = 2,
                            DepartamentNameID = 2
                        },
                        new
                        {
                            Id = 11,
                            CompanyID = 2,
                            DepartamentNameID = 3
                        },
                        new
                        {
                            Id = 12,
                            CompanyID = 2,
                            DepartamentNameID = 4
                        },
                        new
                        {
                            Id = 13,
                            CompanyID = 2,
                            DepartamentNameID = 5
                        },
                        new
                        {
                            Id = 14,
                            CompanyID = 2,
                            DepartamentNameID = 6
                        },
                        new
                        {
                            Id = 15,
                            CompanyID = 2,
                            DepartamentNameID = 7
                        },
                        new
                        {
                            Id = 16,
                            CompanyID = 2,
                            DepartamentNameID = 8
                        },
                        new
                        {
                            Id = 17,
                            CompanyID = 3,
                            DepartamentNameID = 1
                        },
                        new
                        {
                            Id = 18,
                            CompanyID = 3,
                            DepartamentNameID = 2
                        },
                        new
                        {
                            Id = 19,
                            CompanyID = 3,
                            DepartamentNameID = 3
                        },
                        new
                        {
                            Id = 20,
                            CompanyID = 3,
                            DepartamentNameID = 4
                        },
                        new
                        {
                            Id = 21,
                            CompanyID = 3,
                            DepartamentNameID = 5
                        },
                        new
                        {
                            Id = 22,
                            CompanyID = 3,
                            DepartamentNameID = 6
                        },
                        new
                        {
                            Id = 23,
                            CompanyID = 3,
                            DepartamentNameID = 7
                        },
                        new
                        {
                            Id = 24,
                            CompanyID = 3,
                            DepartamentNameID = 8
                        },
                        new
                        {
                            Id = 25,
                            CompanyID = 4,
                            DepartamentNameID = 1
                        },
                        new
                        {
                            Id = 26,
                            CompanyID = 4,
                            DepartamentNameID = 2
                        },
                        new
                        {
                            Id = 27,
                            CompanyID = 4,
                            DepartamentNameID = 3
                        },
                        new
                        {
                            Id = 28,
                            CompanyID = 4,
                            DepartamentNameID = 4
                        },
                        new
                        {
                            Id = 29,
                            CompanyID = 4,
                            DepartamentNameID = 5
                        },
                        new
                        {
                            Id = 30,
                            CompanyID = 4,
                            DepartamentNameID = 6
                        },
                        new
                        {
                            Id = 31,
                            CompanyID = 4,
                            DepartamentNameID = 7
                        },
                        new
                        {
                            Id = 32,
                            CompanyID = 4,
                            DepartamentNameID = 8
                        });
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.DepartamentsName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartamentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DepartamentsNames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartamentName = "Administration"
                        },
                        new
                        {
                            Id = 2,
                            DepartamentName = "Marketing"
                        },
                        new
                        {
                            Id = 3,
                            DepartamentName = "HR"
                        },
                        new
                        {
                            Id = 4,
                            DepartamentName = "Accounting"
                        },
                        new
                        {
                            Id = 5,
                            DepartamentName = "IT"
                        },
                        new
                        {
                            Id = 6,
                            DepartamentName = "Legal"
                        },
                        new
                        {
                            Id = 7,
                            DepartamentName = "Production"
                        },
                        new
                        {
                            Id = 8,
                            DepartamentName = "Engineering"
                        });
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartamentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Salary")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("UnionMember")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartamentId = 1,
                            FirstName = "FName1",
                            LastName = "LName1",
                            Salary = 95000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 2,
                            DepartamentId = 2,
                            FirstName = "FName2",
                            LastName = "LName2",
                            Salary = 40000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 3,
                            DepartamentId = 3,
                            FirstName = "FName3",
                            LastName = "LName3",
                            Salary = 50000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 4,
                            DepartamentId = 4,
                            FirstName = "FName4",
                            LastName = "LName4",
                            Salary = 50000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 5,
                            DepartamentId = 6,
                            FirstName = "FName5",
                            LastName = "LName5",
                            Salary = 70000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 6,
                            DepartamentId = 7,
                            FirstName = "FName6",
                            LastName = "LName6",
                            Salary = 70000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 7,
                            DepartamentId = 7,
                            FirstName = "FName7",
                            LastName = "LName7",
                            Salary = 45000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 8,
                            DepartamentId = 8,
                            FirstName = "FName8",
                            LastName = "LName8",
                            Salary = 44000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 9,
                            DepartamentId = 1,
                            FirstName = "FName9",
                            LastName = "LName9",
                            Salary = 25000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 10,
                            DepartamentId = 5,
                            FirstName = "FName10",
                            LastName = "LName10",
                            Salary = 45000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 11,
                            DepartamentId = 5,
                            FirstName = "FName11",
                            LastName = "LName11",
                            Salary = 35000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 12,
                            DepartamentId = 2,
                            FirstName = "FName12",
                            LastName = "LName12",
                            Salary = 35000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 13,
                            DepartamentId = 2,
                            FirstName = "FName13",
                            LastName = "LName13",
                            Salary = 30000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 14,
                            DepartamentId = 5,
                            FirstName = "FName14",
                            LastName = "LName14",
                            Salary = 0m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 15,
                            DepartamentId = 21,
                            FirstName = "FName15",
                            LastName = "LName15",
                            Salary = 35000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 16,
                            DepartamentId = 13,
                            FirstName = "FName16",
                            LastName = "LName16",
                            Salary = 45000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 17,
                            DepartamentId = 9,
                            FirstName = "FName17",
                            LastName = "LName17",
                            Salary = 45000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 18,
                            DepartamentId = 11,
                            FirstName = "FName18",
                            LastName = "LName18",
                            Salary = 35000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 19,
                            DepartamentId = 10,
                            FirstName = "FName19",
                            LastName = "LName19",
                            Salary = 35000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 20,
                            DepartamentId = 13,
                            FirstName = "FName20",
                            LastName = "LName20",
                            Salary = 45000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 21,
                            DepartamentId = 14,
                            FirstName = "FName21",
                            LastName = "LName21",
                            Salary = 35000m,
                            UnionMember = false
                        },
                        new
                        {
                            Id = 22,
                            DepartamentId = 17,
                            FirstName = "FName22",
                            LastName = "LName22",
                            Salary = 25000m,
                            UnionMember = true
                        },
                        new
                        {
                            Id = 23,
                            DepartamentId = 25,
                            FirstName = "FName23",
                            LastName = "LName23",
                            Salary = 25000m,
                            UnionMember = false
                        });
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("JobDescription")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            JobDescription = "Money Handler",
                            JobName = "Accountant"
                        },
                        new
                        {
                            Id = 2,
                            JobDescription = "I love Humans",
                            JobName = "HR Manager"
                        },
                        new
                        {
                            Id = 3,
                            JobDescription = "Company geek",
                            JobName = "C# Developer"
                        },
                        new
                        {
                            Id = 4,
                            JobDescription = "Can sell anything",
                            JobName = "Sales Representative"
                        },
                        new
                        {
                            Id = 5,
                            JobDescription = "the little boss",
                            JobName = "Product manager"
                        },
                        new
                        {
                            Id = 6,
                            JobDescription = "Keeps trouble away",
                            JobName = "Lawyer"
                        },
                        new
                        {
                            Id = 7,
                            JobDescription = "Everything needs to be clean",
                            JobName = "Maintenance personnel"
                        },
                        new
                        {
                            Id = 8,
                            JobDescription = "http",
                            JobName = "Network Engeneer"
                        },
                        new
                        {
                            Id = 9,
                            JobDescription = "TechSupport",
                            JobName = "IT Specialist"
                        },
                        new
                        {
                            Id = 10,
                            JobDescription = "work in progress",
                            JobName = "Intership Personnel"
                        },
                        new
                        {
                            Id = 11,
                            JobDescription = "the high chief",
                            JobName = "CEO"
                        },
                        new
                        {
                            Id = 12,
                            JobDescription = "Another geek",
                            JobName = "Product Engeneer"
                        });
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Position", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "JobId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("JobId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            JobId = 11
                        },
                        new
                        {
                            EmployeeId = 2,
                            JobId = 4
                        },
                        new
                        {
                            EmployeeId = 3,
                            JobId = 2
                        },
                        new
                        {
                            EmployeeId = 4,
                            JobId = 1
                        },
                        new
                        {
                            EmployeeId = 5,
                            JobId = 6
                        },
                        new
                        {
                            EmployeeId = 6,
                            JobId = 12
                        },
                        new
                        {
                            EmployeeId = 7,
                            JobId = 9
                        },
                        new
                        {
                            EmployeeId = 8,
                            JobId = 12
                        },
                        new
                        {
                            EmployeeId = 9,
                            JobId = 8
                        },
                        new
                        {
                            EmployeeId = 10,
                            JobId = 3
                        },
                        new
                        {
                            EmployeeId = 11,
                            JobId = 3
                        },
                        new
                        {
                            EmployeeId = 12,
                            JobId = 4
                        },
                        new
                        {
                            EmployeeId = 13,
                            JobId = 10
                        },
                        new
                        {
                            EmployeeId = 14,
                            JobId = 10
                        },
                        new
                        {
                            EmployeeId = 15,
                            JobId = 9
                        },
                        new
                        {
                            EmployeeId = 16,
                            JobId = 9
                        },
                        new
                        {
                            EmployeeId = 17,
                            JobId = 11
                        },
                        new
                        {
                            EmployeeId = 18,
                            JobId = 2
                        },
                        new
                        {
                            EmployeeId = 19,
                            JobId = 4
                        },
                        new
                        {
                            EmployeeId = 20,
                            JobId = 3
                        },
                        new
                        {
                            EmployeeId = 21,
                            JobId = 6
                        },
                        new
                        {
                            EmployeeId = 22,
                            JobId = 7
                        },
                        new
                        {
                            EmployeeId = 23,
                            JobId = 7
                        });
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Departament", b =>
                {
                    b.HasOne("CompanyInfo.Data.Entities.Company", "Company")
                        .WithMany("Departaments")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyInfo.Data.Entities.DepartamentsName", "DepartamentsName")
                        .WithMany("Departaments")
                        .HasForeignKey("DepartamentsNameId");

                    b.Navigation("Company");

                    b.Navigation("DepartamentsName");
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Employee", b =>
                {
                    b.HasOne("CompanyInfo.Data.Entities.Departament", "Departament")
                        .WithMany("Employees")
                        .HasForeignKey("DepartamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departament");
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Position", b =>
                {
                    b.HasOne("CompanyInfo.Data.Entities.Employee", "Employee")
                        .WithOne("Position")
                        .HasForeignKey("CompanyInfo.Data.Entities.Position", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyInfo.Data.Entities.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Company", b =>
                {
                    b.Navigation("Departaments");
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Departament", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.DepartamentsName", b =>
                {
                    b.Navigation("Departaments");
                });

            modelBuilder.Entity("CompanyInfo.Data.Entities.Employee", b =>
                {
                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}
