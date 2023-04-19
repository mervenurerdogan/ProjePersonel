﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjePersonelDataAccess.Context;

#nullable disable

namespace ProjePersonelDataAccess.Migrations
{
    [DbContext(typeof(ProjePersonelContext))]
    [Migration("20230418184540_mig-4")]
    partial class mig4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjePersonelModel.Entities.Departman", b =>
                {
                    b.Property<int>("DepartmanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmanID"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmanName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("DepartmanID");

                    b.ToTable("Departments", (string)null);

                    b.HasData(
                        new
                        {
                            DepartmanID = 1,
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(4573),
                            DepartmanName = "Yazılım",
                            Description = "A şirketinin    Yazılım Bölümü ",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            DepartmanID = 2,
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(4579),
                            DepartmanName = "Muhasebe",
                            Description = "A şirketinin    Muhasebe Bölümü ",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Gender", b =>
                {
                    b.Property<int>("GenderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderID"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("GenderID");

                    b.ToTable("Genders", (string)null);

                    b.HasData(
                        new
                        {
                            GenderID = 1,
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3584),
                            GenderName = "Kadın",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            GenderID = 2,
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3585),
                            GenderName = "Erkek",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Mission", b =>
                {
                    b.Property<int>("MissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MissionID"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmanID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MissionName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("MissionID");

                    b.HasIndex("DepartmanID");

                    b.ToTable("PersonnelMissions", (string)null);

                    b.HasData(
                        new
                        {
                            MissionID = 1,
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3037),
                            DepartmanID = 1,
                            Description = "A şirketi  yazılım bölümünde çalışan görevi mühendis olan kişi",
                            IsActive = true,
                            IsDeleted = false,
                            MissionName = "Mühendis"
                        },
                        new
                        {
                            MissionID = 2,
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(3041),
                            DepartmanID = 2,
                            Description = "A şirketi  muhasebe bölümünde çalışan görevi muhasebeci olan kişi",
                            IsActive = true,
                            IsDeleted = false,
                            MissionName = "Muhasebeci"
                        });
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.PersonelPhoneNumber", b =>
                {
                    b.Property<int>("PersonnelPhoneNumberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonnelPhoneNumberID"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("NumberDescription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("PersonnelID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("PersonnelPhoneNumberID");

                    b.HasIndex("PersonnelID");

                    b.ToTable("PersonnelPhoneNumbers", (string)null);

                    b.HasData(
                        new
                        {
                            PersonnelPhoneNumberID = 1,
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(6764),
                            IsActive = true,
                            IsDeleted = false,
                            NumberDescription = "Cep Telefon Numarası",
                            PersonnelID = 1,
                            PhoneNumber = "98763215472"
                        });
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Personnel", b =>
                {
                    b.Property<int>("PersonnelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonnelID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmanID")
                        .HasColumnType("int");

                    b.Property<string>("EducationStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishWorkDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GenderID")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MissionID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartWorkDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SummaryInfoPersonnel")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PersonnelID");

                    b.HasIndex("DepartmanID");

                    b.HasIndex("GenderID");

                    b.HasIndex("MissionID");

                    b.ToTable("Personnels", (string)null);

                    b.HasData(
                        new
                        {
                            PersonnelID = 1,
                            BirthDate = new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(1762),
                            DepartmanID = 1,
                            EducationStatus = "Lisans",
                            Email = "user@gmail.com",
                            FinishWorkDate = new DateTime(2022, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            GenderID = 1,
                            IdentityNumber = "98765432122",
                            IsActive = true,
                            IsDeleted = false,
                            MissionID = 1,
                            Name = "Ayşe",
                            PlaceOfBirth = "Ankara",
                            StartWorkDate = new DateTime(2022, 2, 1, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            SummaryInfoPersonnel = "Personel Açıklama hakkında ",
                            Surname = "Yılmaz",
                            UpdateDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 15, DateTimeKind.Local).AddTicks(1751)
                        });
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.PersonnelAddress", b =>
                {
                    b.Property<int>("AdressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdressID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("AddressDescription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PersonnelID")
                        .HasColumnType("int");

                    b.HasKey("AdressID");

                    b.HasIndex("PersonnelID");

                    b.ToTable("PersonnelAddresses", (string)null);

                    b.HasData(
                        new
                        {
                            AdressID = 1,
                            Address = "Çiçek sokak gül apartmanı No10",
                            AddressDescription = "Ev Adresi",
                            CreatedDateTime = new DateTime(2023, 4, 18, 21, 45, 40, 14, DateTimeKind.Local).AddTicks(8545),
                            IsActive = true,
                            IsDeleted = false,
                            PersonnelID = 1
                        });
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Mission", b =>
                {
                    b.HasOne("ProjePersonelModel.Entities.Departman", "Departman")
                        .WithMany("Missions")
                        .HasForeignKey("DepartmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.PersonelPhoneNumber", b =>
                {
                    b.HasOne("ProjePersonelModel.Entities.Personnel", "Personnel")
                        .WithMany("PersonnelPhoneNumbers")
                        .HasForeignKey("PersonnelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Personnel", b =>
                {
                    b.HasOne("ProjePersonelModel.Entities.Departman", "Departman")
                        .WithMany("Personnels")
                        .HasForeignKey("DepartmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjePersonelModel.Entities.Gender", "Gender")
                        .WithMany("Personnels")
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjePersonelModel.Entities.Mission", "Mission")
                        .WithMany("Personnels")
                        .HasForeignKey("MissionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");

                    b.Navigation("Gender");

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.PersonnelAddress", b =>
                {
                    b.HasOne("ProjePersonelModel.Entities.Personnel", "Personnel")
                        .WithMany("PersonnelAddresses")
                        .HasForeignKey("PersonnelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Departman", b =>
                {
                    b.Navigation("Missions");

                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Gender", b =>
                {
                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Mission", b =>
                {
                    b.Navigation("Personnels");
                });

            modelBuilder.Entity("ProjePersonelModel.Entities.Personnel", b =>
                {
                    b.Navigation("PersonnelAddresses");

                    b.Navigation("PersonnelPhoneNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
