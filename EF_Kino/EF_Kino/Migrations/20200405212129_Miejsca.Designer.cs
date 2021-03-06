﻿// <auto-generated />
using EF_Kino;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Kino.Migrations
{
    [DbContext(typeof(EF_KinoContext))]
    [Migration("20200405212129_Miejsca")]
    partial class Miejsca
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
#pragma warning restore 612, 618
        }
    }
}
