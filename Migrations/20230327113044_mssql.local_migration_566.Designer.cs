﻿// <auto-generated />
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
    [Migration("20230327113044_mssql.local_migration_566")]
    partial class mssqllocal_migration_566
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

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.ProjektArucikkhez", b =>
                {
                    b.Property<int>("ProjectToItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectToItemID"));

                    b.Property<string>("Arucikknev")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProjectToItemID");

                    b.HasIndex("Arucikknev");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjektekArucikkhez");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Projektek", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("User")
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

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.Polc", b =>
                {
                    b.HasOne("napelem_telepito_kozpont.Backend.Modells_Tables.Arucikk", "Arucikk")
                        .WithMany()
                        .HasForeignKey("ItemName");

                    b.Navigation("Arucikk");
                });

            modelBuilder.Entity("napelem_telepito_kozpont.Backend.Modells_Tables.ProjektArucikkhez", b =>
                {
                    b.HasOne("napelem_telepito_kozpont.Backend.Modells_Tables.Arucikk", "Arucikk")
                        .WithMany()
                        .HasForeignKey("Arucikknev");

                    b.HasOne("napelem_telepito_kozpont.Backend.Modells_Tables.Projektek", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arucikk");

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}
