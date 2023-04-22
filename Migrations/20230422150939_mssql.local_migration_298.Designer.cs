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
    [Migration("20230422150939_mssql.local_migration_298")]
    partial class mssqllocal_migration_298
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
                    b.Property<string>("Arucikknev")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaxOnShelf")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Arucikknev");

                    b.ToTable("Arucikk");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Felhasznalo", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("Felhasznalo");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Polc", b =>
                {
                    b.Property<int>("ShelfID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShelfID"));

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ItemsInShelf")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("ShelfID");

                    b.HasIndex("ItemName");

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

                    b.Property<string>("ClientID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectManagerID")
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

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Polc", b =>
                {
                    b.HasOne("napelem_telepito_kozpont.Backend.Modells_Tables.Arucikk", "Arucikk")
                        .WithMany()
                        .HasForeignKey("ItemName");

                    b.Navigation("Arucikk");
                });
#pragma warning restore 612, 618
        }
    }
}
