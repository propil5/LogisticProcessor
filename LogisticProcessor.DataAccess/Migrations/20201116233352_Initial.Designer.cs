﻿// <auto-generated />
using System;
using LogisticProcessor.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogisticProcessor.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201116233352_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LogisticProcessor.DataAccess.Models.AddressDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AddressDto");
                });

            modelBuilder.Entity("LogisticProcessor.DataAccess.Models.CompanyDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("LogisticProcessor.DataAccess.Models.PalletDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DispacheTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Pallets");
                });

            modelBuilder.Entity("LogisticProcessor.DataAccess.Models.ProductDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Depth")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PalletId")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PalletId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("LogisticProcessor.DataAccess.Models.CompanyDto", b =>
                {
                    b.HasOne("LogisticProcessor.DataAccess.Models.AddressDto", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("LogisticProcessor.DataAccess.Models.PalletDto", b =>
                {
                    b.HasOne("LogisticProcessor.DataAccess.Models.CompanyDto", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("LogisticProcessor.DataAccess.Models.ProductDto", b =>
                {
                    b.HasOne("LogisticProcessor.DataAccess.Models.PalletDto", "Pallet")
                        .WithMany()
                        .HasForeignKey("PalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pallet");
                });
#pragma warning restore 612, 618
        }
    }
}
