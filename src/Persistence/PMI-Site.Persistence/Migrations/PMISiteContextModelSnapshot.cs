﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMI_Site.Persistence.Contexts.EntityFramework;

#nullable disable

namespace PMI_Site.Persistence.Migrations
{
    [DbContext(typeof(PMISiteContext))]
    partial class PMISiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PMI_Site.Domain.Entities.DigitalSignage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Cloud")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SiteId")
                        .IsUnique();

                    b.ToTable("DigitalSignages");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.GeneralInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LaunchYear")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfEmployees")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SiteSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiteStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiteId")
                        .IsUnique();

                    b.ToTable("GeneralInformations");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.ITContact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ITContactCategory")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserJobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("ITContacts");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.MeetingRoom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfStandardMeetingRooms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TotalMeetingRooms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SiteId")
                        .IsUnique();

                    b.ToTable("MeetingRooms");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.ServerRoom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfServerRooms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TotalMeetingRooms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SiteId")
                        .IsUnique();

                    b.ToTable("ServerRooms");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryISO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LocalTeam")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiteType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.DigitalSignage", b =>
                {
                    b.HasOne("PMI_Site.Domain.Entities.Site", "Site")
                        .WithOne("DigitalSignage")
                        .HasForeignKey("PMI_Site.Domain.Entities.DigitalSignage", "SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.GeneralInformation", b =>
                {
                    b.HasOne("PMI_Site.Domain.Entities.Site", "Site")
                        .WithOne("GeneralInformation")
                        .HasForeignKey("PMI_Site.Domain.Entities.GeneralInformation", "SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.ITContact", b =>
                {
                    b.HasOne("PMI_Site.Domain.Entities.Site", "Site")
                        .WithMany("Contacts")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.MeetingRoom", b =>
                {
                    b.HasOne("PMI_Site.Domain.Entities.Site", "Site")
                        .WithOne("MeetingRoom")
                        .HasForeignKey("PMI_Site.Domain.Entities.MeetingRoom", "SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.ServerRoom", b =>
                {
                    b.HasOne("PMI_Site.Domain.Entities.Site", "Site")
                        .WithOne("ServerRoom")
                        .HasForeignKey("PMI_Site.Domain.Entities.ServerRoom", "SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("PMI_Site.Domain.Entities.Site", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("DigitalSignage")
                        .IsRequired();

                    b.Navigation("GeneralInformation")
                        .IsRequired();

                    b.Navigation("MeetingRoom")
                        .IsRequired();

                    b.Navigation("ServerRoom")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
