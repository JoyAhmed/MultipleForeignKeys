﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiForeignKeys.Data;

namespace MultiForeignKeys.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190829191136_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MultiForeignKeys.Models.Designations", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeTypeId");

                    b.HasKey("DesignationId");

                    b.HasIndex("EmployeeTypeId");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("MultiForeignKeys.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DesignationIdOne");

                    b.Property<int?>("DesignationIdThree");

                    b.Property<int?>("DesignationIdTwo");

                    b.Property<string>("EmployeeName");

                    b.Property<int?>("EmployeeTypeIdOne");

                    b.Property<int?>("EmployeeTypeIdThree");

                    b.Property<int?>("EmployeeTypeIdTwo");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DesignationIdOne");

                    b.HasIndex("DesignationIdThree");

                    b.HasIndex("DesignationIdTwo");

                    b.HasIndex("EmployeeTypeIdOne");

                    b.HasIndex("EmployeeTypeIdThree");

                    b.HasIndex("EmployeeTypeIdTwo");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MultiForeignKeys.Models.EmployeeType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName");

                    b.HasKey("TypeId");

                    b.ToTable("EmployeeType");
                });

            modelBuilder.Entity("MultiForeignKeys.Models.Designations", b =>
                {
                    b.HasOne("MultiForeignKeys.Models.EmployeeType", "EmployeeType")
                        .WithMany("Designations")
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MultiForeignKeys.Models.Employee", b =>
                {
                    b.HasOne("MultiForeignKeys.Models.Designations", "ForTypeOne")
                        .WithMany("One")
                        .HasForeignKey("DesignationIdOne");

                    b.HasOne("MultiForeignKeys.Models.Designations", "ForTypeThree")
                        .WithMany("Three")
                        .HasForeignKey("DesignationIdThree");

                    b.HasOne("MultiForeignKeys.Models.Designations", "ForTypeTwo")
                        .WithMany("Two")
                        .HasForeignKey("DesignationIdTwo");

                    b.HasOne("MultiForeignKeys.Models.EmployeeType", "TypeOne")
                        .WithMany("One")
                        .HasForeignKey("EmployeeTypeIdOne");

                    b.HasOne("MultiForeignKeys.Models.EmployeeType", "TypeThree")
                        .WithMany("Three")
                        .HasForeignKey("EmployeeTypeIdThree");

                    b.HasOne("MultiForeignKeys.Models.EmployeeType", "TypeTwo")
                        .WithMany("Two")
                        .HasForeignKey("EmployeeTypeIdTwo");
                });
#pragma warning restore 612, 618
        }
    }
}
