﻿// <auto-generated />
using System;
using Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment.Migrations
{
    [DbContext(typeof(DataTaskContext))]
    [Migration("20201127140251_Assignmet")]
    partial class Assignmet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment.Models.DataTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Finish_Date");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Start_Date");

                    b.Property<float>("Total_Of_Hours");

                    b.Property<DateTime>("What_Date");

                    b.HasKey("ID");

                    b.ToTable("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}
