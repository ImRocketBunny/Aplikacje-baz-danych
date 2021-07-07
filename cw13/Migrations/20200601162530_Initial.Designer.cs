﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cw13.Models;

namespace cw13.Migrations
{
    [DbContext(typeof(CukierniaDbContext))]
    [Migration("20200601162530_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cw13.Models.Klient", b =>
                {
                    b.Property<int>("IdKlient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdKlient");

                    b.ToTable("Klienci");

                    b.HasData(
                        new
                        {
                            IdKlient = 1,
                            Imie = "Klient1",
                            Nazwisko = "1"
                        },
                        new
                        {
                            IdKlient = 2,
                            Imie = "Klient2",
                            Nazwisko = "2"
                        },
                        new
                        {
                            IdKlient = 3,
                            Imie = "Klient3",
                            Nazwisko = "3"
                        });
                });

            modelBuilder.Entity("cw13.Models.Pracownik", b =>
                {
                    b.Property<int>("IdPracownik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdPracownik");

                    b.ToTable("Pracownicy");

                    b.HasData(
                        new
                        {
                            IdPracownik = 1,
                            Imie = "Pracownik1",
                            Nazwisko = "1"
                        },
                        new
                        {
                            IdPracownik = 2,
                            Imie = "Pracownik2",
                            Nazwisko = "2"
                        },
                        new
                        {
                            IdPracownik = 3,
                            Imie = "Pracownik3",
                            Nazwisko = "3"
                        });
                });

            modelBuilder.Entity("cw13.Models.WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CenaZaSzt")
                        .HasColumnType("real");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("IdWyrobuCukierniczego");

                    b.ToTable("WyrobCukiernicze");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            CenaZaSzt = 1f,
                            Nazwa = "Wyrob1",
                            Typ = "Typ1"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            CenaZaSzt = 2f,
                            Nazwa = "Wyrob2",
                            Typ = "Typ2"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 3,
                            CenaZaSzt = 3f,
                            Nazwa = "Wyrob3",
                            Typ = "Typ3"
                        });
                });

            modelBuilder.Entity("cw13.Models.Zamowienie", b =>
                {
                    b.Property<int>("IdZamowienia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPrzyjecia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRealizacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdKlient")
                        .HasColumnType("int");

                    b.Property<int>("IdPracownik")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdZamowienia");

                    b.HasIndex("IdKlient");

                    b.HasIndex("IdPracownik");

                    b.ToTable("Zamowienia");

                    b.HasData(
                        new
                        {
                            IdZamowienia = 1,
                            DataPrzyjecia = new DateTime(2020, 6, 1, 18, 25, 29, 863, DateTimeKind.Local).AddTicks(9286),
                            DataRealizacji = new DateTime(2020, 6, 1, 18, 25, 29, 866, DateTimeKind.Local).AddTicks(8821),
                            IdKlient = 1,
                            IdPracownik = 1,
                            Uwagi = "brak1"
                        },
                        new
                        {
                            IdZamowienia = 2,
                            DataPrzyjecia = new DateTime(2020, 6, 1, 18, 25, 29, 867, DateTimeKind.Local).AddTicks(179),
                            DataRealizacji = new DateTime(2020, 6, 1, 18, 25, 29, 867, DateTimeKind.Local).AddTicks(196),
                            IdKlient = 2,
                            IdPracownik = 2,
                            Uwagi = "brak2"
                        },
                        new
                        {
                            IdZamowienia = 3,
                            DataPrzyjecia = new DateTime(2020, 6, 1, 18, 25, 29, 867, DateTimeKind.Local).AddTicks(220),
                            DataRealizacji = new DateTime(2020, 6, 1, 18, 25, 29, 867, DateTimeKind.Local).AddTicks(223),
                            IdKlient = 3,
                            IdPracownik = 3,
                            Uwagi = "brak3"
                        });
                });

            modelBuilder.Entity("cw13.Models.Zamowienie_WyrobCukierniczy", b =>
                {
                    b.Property<int>("IdWyrobuCukierniczego")
                        .HasColumnType("int");

                    b.Property<int>("IdZamowienia")
                        .HasColumnType("int");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Uwagi")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("IdWyrobuCukierniczego", "IdZamowienia");

                    b.HasIndex("IdZamowienia");

                    b.ToTable("Zamowienie_WyrobyCukiernicze");

                    b.HasData(
                        new
                        {
                            IdWyrobuCukierniczego = 1,
                            IdZamowienia = 1,
                            Ilosc = 1,
                            Uwagi = "Uwaga1"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 2,
                            IdZamowienia = 2,
                            Ilosc = 2,
                            Uwagi = "Uwag2"
                        },
                        new
                        {
                            IdWyrobuCukierniczego = 3,
                            IdZamowienia = 3,
                            Ilosc = 3,
                            Uwagi = "Uwaga3"
                        });
                });

            modelBuilder.Entity("cw13.Models.Zamowienie", b =>
                {
                    b.HasOne("cw13.Models.Klient", "Klient")
                        .WithMany("Zamowienia")
                        .HasForeignKey("IdKlient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cw13.Models.Pracownik", "Pracownik")
                        .WithMany("Zamowienia")
                        .HasForeignKey("IdPracownik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cw13.Models.Zamowienie_WyrobCukierniczy", b =>
                {
                    b.HasOne("cw13.Models.WyrobCukierniczy", "WyrobCukierniczy")
                        .WithMany("Zamowienie_WyrobCukiernicze")
                        .HasForeignKey("IdWyrobuCukierniczego")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cw13.Models.Zamowienie", "Zamowienie")
                        .WithMany("Zamowienie_WyrobCukiernicze")
                        .HasForeignKey("IdZamowienia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
