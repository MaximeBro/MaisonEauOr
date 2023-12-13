﻿// <auto-generated />
using System;
using MaisonEauOr.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaisonEauOr.Migrations
{
    [DbContext(typeof(MeoDbContext))]
    partial class MeoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("MaisonEauOr.Models.Products.Cosmetics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Volume")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Cosmetics");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.HairProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("HairProducts");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Honey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Honeys");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.MadeHome", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MadeHome");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Mist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Mists");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.MuscTahara", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MuscTaharas");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Option", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("HairProductId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("HoneyId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MadeHomeId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MistId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("MuscTaharaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PerfumeId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HairProductId");

                    b.HasIndex("HoneyId");

                    b.HasIndex("MadeHomeId");

                    b.HasIndex("MistId");

                    b.HasIndex("MuscTaharaId");

                    b.HasIndex("PerfumeId");

                    b.ToTable("Option");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Perfume", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Gourmet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StockAmount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Perfumes");
                });

            modelBuilder.Entity("MaisonEauOr.Models.UserAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BornAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firstname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Town")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Option", b =>
                {
                    b.HasOne("MaisonEauOr.Models.Products.HairProduct", null)
                        .WithMany("Options")
                        .HasForeignKey("HairProductId");

                    b.HasOne("MaisonEauOr.Models.Products.Honey", null)
                        .WithMany("Options")
                        .HasForeignKey("HoneyId");

                    b.HasOne("MaisonEauOr.Models.Products.MadeHome", null)
                        .WithMany("Options")
                        .HasForeignKey("MadeHomeId");

                    b.HasOne("MaisonEauOr.Models.Products.Mist", null)
                        .WithMany("Scents")
                        .HasForeignKey("MistId");

                    b.HasOne("MaisonEauOr.Models.Products.MuscTahara", null)
                        .WithMany("Options")
                        .HasForeignKey("MuscTaharaId");

                    b.HasOne("MaisonEauOr.Models.Products.Perfume", null)
                        .WithMany("Options")
                        .HasForeignKey("PerfumeId");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.HairProduct", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Honey", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.MadeHome", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Mist", b =>
                {
                    b.Navigation("Scents");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.MuscTahara", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Products.Perfume", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}
