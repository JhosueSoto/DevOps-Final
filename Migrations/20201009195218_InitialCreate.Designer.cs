﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial;

namespace Parcial.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20201009195218_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Parcial.persona", b =>
                {
                    b.Property<int>("personaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("lugar")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("vehiculoid")
                        .HasColumnType("INTEGER");

                    b.HasKey("personaid");

                    b.HasIndex("vehiculoid");

                    b.ToTable("personas");
                });

            modelBuilder.Entity("Parcial.vehiculo", b =>
                {
                    b.Property<int>("vehiculoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("color")
                        .HasColumnType("TEXT");

                    b.Property<string>("descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("marca")
                        .HasColumnType("TEXT");

                    b.Property<string>("modelo")
                        .HasColumnType("TEXT");

                    b.Property<string>("placa")
                        .HasColumnType("TEXT");

                    b.HasKey("vehiculoid");

                    b.ToTable("vehiculos");
                });

            modelBuilder.Entity("Parcial.persona", b =>
                {
                    b.HasOne("Parcial.vehiculo", "vehiculo")
                        .WithMany("personas")
                        .HasForeignKey("vehiculoid");
                });
#pragma warning restore 612, 618
        }
    }
}
