﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceCrabs.Models;

namespace SpaceCrabs.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SpaceCrabs.Models.Crab", b =>
                {
                    b.Property<int>("CrabId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SpaceCraft")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Weapon")
                        .IsRequired();

                    b.HasKey("CrabId");

                    b.ToTable("Crabs");
                });

            modelBuilder.Entity("SpaceCrabs.Models.Planet", b =>
                {
                    b.Property<int>("PlanetId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Galaxy")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("System")
                        .IsRequired();

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("PlanetId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("SpaceCrabs.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CrabId");

                    b.Property<int>("PlanetId");

                    b.HasKey("TripId");

                    b.HasIndex("CrabId");

                    b.HasIndex("PlanetId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("SpaceCrabs.Models.Trip", b =>
                {
                    b.HasOne("SpaceCrabs.Models.Crab", "Tourist")
                        .WithMany("Trips")
                        .HasForeignKey("CrabId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpaceCrabs.Models.Planet", "Vacation")
                        .WithMany("Tours")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
