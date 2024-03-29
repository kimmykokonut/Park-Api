﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkApi.Models;

#nullable disable

namespace ParkApi.Migrations
{
    [DbContext(typeof(ParkApiContext))]
    [Migration("20240223175203_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Campground")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Designation")
                        .HasColumnType("longtext");

                    b.Property<bool>("EntryFee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FeeType")
                        .HasColumnType("longtext");

                    b.Property<string>("LatLong")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("WebUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("YearEst")
                        .HasColumnType("int");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");
                });
#pragma warning restore 612, 618
        }
    }
}
