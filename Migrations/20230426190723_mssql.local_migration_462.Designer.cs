﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using napelem_telepito_kozpont.Backend.DatabaseConnection;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    [DbContext(typeof(NapelemDbContext))]
    [Migration("20230426190723_mssql.local_migration_462")]
    partial class mssqllocal_migration_462
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Arucikk", b =>
                {
                    b.Property<int>("ArucikkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArucikkID"));

                    b.Property<string>("Arucikknev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxOnShelf")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ArucikkID");

                    b.ToTable("Arucikk");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Felhasznalo", b =>
                {
                    b.Property<int>("FelhasznaloID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FelhasznaloID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("FelhasznaloID");

                    b.ToTable("Felhasznalo");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Megrendelo", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Megrendelok");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Polc", b =>
                {
                    b.Property<int>("ShelfID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShelfID"));

                    b.Property<int>("ArucikkID")
                        .HasColumnType("int");

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<int>("ItemsInShelf")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("ShelfID");

                    b.ToTable("Polc");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.ProjectStatuszok", b =>
                {
                    b.Property<int>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateID"));

                    b.Property<DateTime>("FazisKezdete")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("StateID");

                    b.ToTable("projectStatuszok");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.ProjektArucikkhez", b =>
                {
                    b.Property<int>("ProjectToItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectToItemID"));

                    b.Property<string>("Arucikknev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProjectToItemID");

                    b.ToTable("ProjektekArucikkhez");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Projektek", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"));

                    b.Property<int>("ApproxCost")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApproxTimeToFinish")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("FelhasznaloID")
                        .HasColumnType("int");

                    b.Property<string>("helyszin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("leiras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Projekt");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"));

                    b.Property<string>("StatusInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Státusz");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.UjArucikkIgeny", b =>
                {
                    b.Property<int>("AruIgenyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AruIgenyID"));

                    b.Property<string>("AruNev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mennyiseg")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("AruIgenyID");

                    b.ToTable("ujArucikkIgeny");
                });
#pragma warning restore 612, 618
        }
    }
}
