﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesCore.Application.Data;

#nullable disable

namespace SalesCore.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221211134738_addInsuranceandplateidIncarmigration")]
    partial class addInsuranceandplateidIncarmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarSales.Core.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("InsuranceNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlateId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarSales.Core.Models.InsuranceContract", b =>
                {
                    b.Property<Guid>("InsuranceNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsuranceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InsuranceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.HasKey("InsuranceNumber");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("insuranceContracts");
                });

            modelBuilder.Entity("CarSales.Core.Models.Plate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("FrontPlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RearPlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique()
                        .HasFilter("[CarId] IS NOT NULL");

                    b.HasIndex("FrontPlate")
                        .IsUnique();

                    b.HasIndex("RearPlate")
                        .IsUnique();

                    b.ToTable("plates");
                });

            modelBuilder.Entity("CarSales.Core.Models.InsuranceContract", b =>
                {
                    b.HasOne("CarSales.Core.Models.Car", "car")
                        .WithOne("InsuranceContract")
                        .HasForeignKey("CarSales.Core.Models.InsuranceContract", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");
                });

            modelBuilder.Entity("CarSales.Core.Models.Plate", b =>
                {
                    b.HasOne("CarSales.Core.Models.Car", "Car")
                        .WithOne("Plate")
                        .HasForeignKey("CarSales.Core.Models.Plate", "CarId");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarSales.Core.Models.Car", b =>
                {
                    b.Navigation("InsuranceContract");

                    b.Navigation("Plate")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
