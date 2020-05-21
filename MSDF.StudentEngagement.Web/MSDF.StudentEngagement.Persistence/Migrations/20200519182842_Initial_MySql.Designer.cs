﻿// <auto-generated />
using System;
using MSDF.StudentEngagement.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSDF.StudentEngagement.Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200519182842_Initial_MySql")]
    partial class Initial_MySql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MSDF.StudentEngagement.Persistence.Models.LearningApp", b =>
                {
                    b.Property<string>("LearningAppIdentifier")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("AppUrl")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("Namespace")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("LearningAppIdentifier");

                    b.ToTable("LearningApp");
                });

            modelBuilder.Entity("MSDF.StudentEngagement.Persistence.Models.StudentInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("BirthSexDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContactInfoCellPhoneNumber")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ContactInfoElectronicMailAddress")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("ContactInfoFirstName")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("ContactInfoLastSurname")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("ContactInfoRelationToStudent")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("DeviceId")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DisabilityStatusDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ELLStatusDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("EconomicallyDisadvantageDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ethnicity")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime?>("ExitWithdrawalDate")
                        .HasColumnType("datetime");

                    b.Property<string>("F504DescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("FosterDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("HomelessDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("IdentityElectronicMailAddress")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("LastSurname")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("LocalEducationAgencyName")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("MiddleName")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("MigrantDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("Race_AmericanIndianAlaskanNative")
                        .HasColumnType("bit");

                    b.Property<bool?>("Race_Asian")
                        .HasColumnType("bit");

                    b.Property<bool?>("Race_BlackAfricaAmerican")
                        .HasColumnType("bit");

                    b.Property<bool?>("Race_ChooseNotToRespond")
                        .HasColumnType("bit");

                    b.Property<bool?>("Race_NativeHawaiianPacificIslander")
                        .HasColumnType("bit");

                    b.Property<bool?>("Race_Other")
                        .HasColumnType("bit");

                    b.Property<bool?>("Race_White")
                        .HasColumnType("bit");

                    b.Property<string>("SchoolCurrentGradeLevelDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SchoolName")
                        .HasColumnType("varchar(75)")
                        .HasMaxLength(75);

                    b.Property<string>("SchoolTypeDescriptorCodeValue")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SchoolYear")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("StudentStateIdentificationCode")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("StudentUSI")
                        .HasColumnType("int");

                    b.Property<string>("StudentUniqueId")
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("StudentInformation");
                });

            modelBuilder.Entity("MSDF.StudentEngagement.Persistence.Models.StudentLearningEventLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DeviceId")
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("IPAddress")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("LeaningAppUrl")
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ReffererUrl")
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("StudentElectronicMailAddress")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("StudentUSI")
                        .HasColumnType("int");

                    b.Property<string>("StudentUniqueId")
                        .HasColumnType("varchar(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("TimeSpent")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UTCEndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UTCStartDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("StudentLearningEventLog");
                });
#pragma warning restore 612, 618
        }
    }
}