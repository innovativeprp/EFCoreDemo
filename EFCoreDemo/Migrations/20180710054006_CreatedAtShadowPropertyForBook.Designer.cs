﻿// <auto-generated />
using System;
using EFCoreDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180710054006_CreatedAtShadowPropertyForBook")]
    partial class CreatedAtShadowPropertyForBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreDemo.Models.Author", b =>
                {
                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("Dob");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.HasKey("FirstName", "LastName");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EFCoreDemo.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Isbn")
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasName("UniqueIsbn")
                        .HasFilter("[Isbn] IS NOT NULL");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
