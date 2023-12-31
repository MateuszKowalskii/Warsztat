﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warsztat_samochodowy.Modele;

#nullable disable

namespace Warsztat_samochodowy.Migrations
{
    [DbContext(typeof(KomunikacjaZBD))]
    [Migration("20230515111145_migration4")]
    partial class migration4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Czesc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ZlecenieId")
                        .HasColumnType("int");

                    b.Property<int>("ilosc")
                        .HasColumnType("int");

                    b.Property<string>("kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("producent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ZlecenieId");

                    b.HasIndex("kod")
                        .IsUnique();

                    b.ToTable("czesci");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Dostawca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("telefon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("nazwa")
                        .IsUnique();

                    b.ToTable("dostawcy");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Klient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PESEL")
                        .HasColumnType("int");

                    b.Property<string>("imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PESEL")
                        .IsUnique();

                    b.ToTable("klienci");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Pracownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PESEL")
                        .HasColumnType("int");

                    b.Property<int?>("ZlecenieId")
                        .HasColumnType("int");

                    b.Property<string>("imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PESEL")
                        .IsUnique();

                    b.HasIndex("ZlecenieId");

                    b.ToTable("pracownicy");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Zamowienie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("dostawcaNazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ilosc")
                        .HasColumnType("int");

                    b.Property<string>("kiedyDotrze")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("zamowienia");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Zlecenie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("dataWykonania")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("oplata")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("zakonczone")
                        .HasColumnType("bit");

                    b.Property<int>("zleceniodawcaPESEL")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("zlecenia");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Czesc", b =>
                {
                    b.HasOne("Warsztat_samochodowy.Rekordy.Zlecenie", null)
                        .WithMany("czesci")
                        .HasForeignKey("ZlecenieId");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Pracownik", b =>
                {
                    b.HasOne("Warsztat_samochodowy.Rekordy.Zlecenie", null)
                        .WithMany("pracownicy")
                        .HasForeignKey("ZlecenieId");
                });

            modelBuilder.Entity("Warsztat_samochodowy.Rekordy.Zlecenie", b =>
                {
                    b.Navigation("czesci");

                    b.Navigation("pracownicy");
                });
#pragma warning restore 612, 618
        }
    }
}
