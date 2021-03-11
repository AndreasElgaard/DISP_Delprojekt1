﻿// <auto-generated />
using System;
using API.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Haandvaerker", b =>
                {
                    b.Property<int>("HaandvaerkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HVAnsaettelsedato")
                        .HasColumnType("datetime2");

                    b.Property<string>("HVEfternavn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HVFagomraade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HVFornavn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HaandvaerkerId");

                    b.ToTable("Haandværkere");
                });

            modelBuilder.Entity("API.Models.Vaerktoej", b =>
                {
                    b.Property<long>("VTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LiggerIvtk")
                        .HasColumnType("int");

                    b.Property<int?>("LiggerIvtkNavigationVTKId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VTAnskaffet")
                        .HasColumnType("datetime2");

                    b.Property<string>("VTFabrikat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VTModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VTSerienr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VTType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VTId");

                    b.HasIndex("LiggerIvtkNavigationVTKId");

                    b.ToTable("Vaerktøjer");
                });

            modelBuilder.Entity("API.Models.Vaerktoejskasse", b =>
                {
                    b.Property<int>("VTKId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EjesAfNavigationHaandvaerkerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("VTKAnskaffet")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VTKEjesAf")
                        .HasColumnType("int");

                    b.Property<string>("VTKFabrikat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VTKFarve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VTKModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VTKSerienummer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VTKId");

                    b.HasIndex("EjesAfNavigationHaandvaerkerId");

                    b.ToTable("Vaerktoejskasser");
                });

            modelBuilder.Entity("API.Models.Vaerktoej", b =>
                {
                    b.HasOne("API.Models.Vaerktoejskasse", "LiggerIvtkNavigation")
                        .WithMany("Vaerktoej")
                        .HasForeignKey("LiggerIvtkNavigationVTKId");

                    b.Navigation("LiggerIvtkNavigation");
                });

            modelBuilder.Entity("API.Models.Vaerktoejskasse", b =>
                {
                    b.HasOne("API.Models.Haandvaerker", "EjesAfNavigation")
                        .WithMany("Vaerktoejskasse")
                        .HasForeignKey("EjesAfNavigationHaandvaerkerId");

                    b.Navigation("EjesAfNavigation");
                });

            modelBuilder.Entity("API.Models.Haandvaerker", b =>
                {
                    b.Navigation("Vaerktoejskasse");
                });

            modelBuilder.Entity("API.Models.Vaerktoejskasse", b =>
                {
                    b.Navigation("Vaerktoej");
                });
#pragma warning restore 612, 618
        }
    }
}
