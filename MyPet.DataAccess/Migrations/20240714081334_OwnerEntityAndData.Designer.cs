﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPet.DataAccess;

namespace MyPet.DataAccess.Migrations
{
    [DbContext(typeof(PetDbContext))]
    [Migration("20240714081334_OwnerEntityAndData")]
    partial class OwnerEntityAndData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyPet.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Chathumini Dasanayake",
                            PhoneNumber = "0712400284"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Nadeesh Fernando",
                            PhoneNumber = "0774964200"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Chandrakeerthi Dasanayake",
                            PhoneNumber = "0718070325"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Nilanthi Adikari",
                            PhoneNumber = "0718195376"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Anjana Dasanayake",
                            PhoneNumber = "0713620646"
                        });
                });

            modelBuilder.Entity("MyPet.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Catogery")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Catogery = "Dog(DB)",
                            Color = "Black & White",
                            Date = new DateTime(2024, 7, 14, 10, 13, 33, 390, DateTimeKind.Local).AddTicks(2058),
                            Name = "Blacky",
                            OwnerId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Catogery = "Dog",
                            Color = "Brown",
                            Date = new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8419),
                            Name = "Chooty",
                            OwnerId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Catogery = "Dog",
                            Color = "Brown and White",
                            Date = new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8467),
                            Name = "Kelly",
                            OwnerId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Catogery = "Dog",
                            Color = "Black",
                            Date = new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8475),
                            Name = "Kikki",
                            OwnerId = 4,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Catogery = "Cat",
                            Color = "Ash",
                            Date = new DateTime(2024, 7, 14, 10, 13, 33, 394, DateTimeKind.Local).AddTicks(8481),
                            Name = "Kitty",
                            OwnerId = 5,
                            Status = 0
                        });
                });

            modelBuilder.Entity("MyPet.Models.Pet", b =>
                {
                    b.HasOne("MyPet.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}