﻿// <auto-generated />
using System;
using EF_Kino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Kino.Migrations
{
    [DbContext(typeof(EF_KinoContext))]
    [Migration("20200405212325_Seanse")]
    partial class Seanse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_Kino.Models.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miasto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumerDomu")
                        .HasColumnType("int");

                    b.Property<int>("NumerTelefonu")
                        .HasColumnType("int");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adresy");
                });

            modelBuilder.Entity("EF_Kino.Models.Bilet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bilety");
                });

            modelBuilder.Entity("EF_Kino.Models.Kino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kina");
                });

            modelBuilder.Entity("EF_Kino.Models.Miejsce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numer")
                        .HasColumnType("int");

                    b.Property<int>("Rzad")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Miejsca");
                });

            modelBuilder.Entity("EF_Kino.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LiczbaMiejsc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("EF_Kino.Models.Seans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_i_Godz_Rozpoczecia")
                        .HasColumnType("datetime2");

                    b.Property<string>("NazwaFIlmu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seanse");
                });
#pragma warning restore 612, 618
        }
    }
}
