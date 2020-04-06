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
    [Migration("20200406090706_Depen")]
    partial class Depen
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
                    b.Property<int>("IdAdresu")
                        .HasColumnType("int");

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

                    b.HasKey("IdAdresu");

                    b.ToTable("Adresy");
                });

            modelBuilder.Entity("EF_Kino.Models.Bilet", b =>
                {
                    b.Property<int>("IdBiletu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<int?>("MiejsceIdMiejsca")
                        .HasColumnType("int");

                    b.Property<int?>("SeansIdSeansu")
                        .HasColumnType("int");

                    b.HasKey("IdBiletu");

                    b.HasIndex("MiejsceIdMiejsca");

                    b.HasIndex("SeansIdSeansu");

                    b.ToTable("Bilety");
                });

            modelBuilder.Entity("EF_Kino.Models.Kino", b =>
                {
                    b.Property<int>("IdKina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKina");

                    b.ToTable("Kina");
                });

            modelBuilder.Entity("EF_Kino.Models.Miejsce", b =>
                {
                    b.Property<int>("IdMiejsca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numer")
                        .HasColumnType("int");

                    b.Property<int>("Rzad")
                        .HasColumnType("int");

                    b.Property<int?>("SalaIdSali")
                        .HasColumnType("int");

                    b.HasKey("IdMiejsca");

                    b.HasIndex("SalaIdSali");

                    b.ToTable("Miejsca");
                });

            modelBuilder.Entity("EF_Kino.Models.Sala", b =>
                {
                    b.Property<int>("IdSali")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KinoIdKina")
                        .HasColumnType("int");

                    b.Property<string>("LiczbaMiejsc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSali");

                    b.HasIndex("KinoIdKina");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("EF_Kino.Models.Seans", b =>
                {
                    b.Property<int>("IdSeansu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_i_Godz_Rozpoczecia")
                        .HasColumnType("datetime2");

                    b.Property<string>("NazwaFIlmu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSeansu");

                    b.ToTable("Seanse");
                });

            modelBuilder.Entity("EF_Kino.Models.Adres", b =>
                {
                    b.HasOne("EF_Kino.Models.Kino", "Kino")
                        .WithOne("AdresKina")
                        .HasForeignKey("EF_Kino.Models.Adres", "IdAdresu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_Kino.Models.Bilet", b =>
                {
                    b.HasOne("EF_Kino.Models.Miejsce", "Miejsce")
                        .WithMany("Bilet")
                        .HasForeignKey("MiejsceIdMiejsca");

                    b.HasOne("EF_Kino.Models.Seans", "Seans")
                        .WithMany("Bilet")
                        .HasForeignKey("SeansIdSeansu");
                });

            modelBuilder.Entity("EF_Kino.Models.Miejsce", b =>
                {
                    b.HasOne("EF_Kino.Models.Sala", "Sala")
                        .WithMany("Miejsce")
                        .HasForeignKey("SalaIdSali");
                });

            modelBuilder.Entity("EF_Kino.Models.Sala", b =>
                {
                    b.HasOne("EF_Kino.Models.Kino", "Kino")
                        .WithMany("Sala")
                        .HasForeignKey("KinoIdKina");
                });
#pragma warning restore 612, 618
        }
    }
}
