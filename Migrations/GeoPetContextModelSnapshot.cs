﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_geopet.Data;

#nullable disable

namespace project_geopet.Migrations
{
    [DbContext(typeof(GeoPetContext))]
    partial class GeoPetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("project_geopet.Models.CaringPerson", b =>
                {
                    b.Property<Guid>("CaringPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Cep")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("CaringPersonId");

                    b.ToTable("CaringPersons");
                });

            modelBuilder.Entity("project_geopet.Models.Pet", b =>
                {
                    b.Property<Guid>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("CaringPersonId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Carrying")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("PetId");

                    b.HasIndex("CaringPersonId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("project_geopet.Models.Pet", b =>
                {
                    b.HasOne("project_geopet.Models.CaringPerson", "CaringPerson")
                        .WithMany("Pets")
                        .HasForeignKey("CaringPersonId");

                    b.Navigation("CaringPerson");
                });

            modelBuilder.Entity("project_geopet.Models.CaringPerson", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
