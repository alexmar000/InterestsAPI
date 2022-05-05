﻿// <auto-generated />
using System;
using InterestsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InterestsApi.Migrations
{
    [DbContext(typeof(InterestDbContext))]
    [Migration("20220430060950_seedData3")]
    partial class seedData3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InterestsApi.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fiske",
                            Url = "www.edgeflyfishing.com",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Höjdhopp",
                            Url = "www.hojdhopp.se",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Utveckling",
                            Url = "www.stackoverflow.com",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("InterestsApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Erik Filipsson",
                            PhoneNumber = "070-3272032"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dina Digiorno",
                            PhoneNumber = "070-6224012"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Simona Ryd",
                            PhoneNumber = "070-7823122"
                        });
                });

            modelBuilder.Entity("InterestsApi.Models.Interest", b =>
                {
                    b.HasOne("InterestsApi.Models.User", null)
                        .WithMany("Interests")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
