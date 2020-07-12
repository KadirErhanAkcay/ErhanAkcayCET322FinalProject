﻿// <auto-generated />
using System;
using ErhanAkcayCET322FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ErhanAkcayCET322FinalProject.Migrations.matchreports
{
    [DbContext(typeof(matchreportsContext))]
    partial class matchreportsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ErhanAkcayCET322FinalProject.Models.MatchReports", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contents");

                    b.Property<int>("MatchId");

                    b.Property<string>("MatchName");

                    b.Property<string>("MatchScore");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("MatchReports");
                });
#pragma warning restore 612, 618
        }
    }
}
