﻿// <auto-generated />
using System;
using MaisonEauOr.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaisonEauOr.Migrations
{
    [DbContext(typeof(MeoDbContext))]
    [Migration("20231219134251_UpdatesOrders")]
    partial class UpdatesOrders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("MaisonEauOr.Models.AuthTokenModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AuthTokens");
                });

            modelBuilder.Entity("MaisonEauOr.Models.BasketProductModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Option")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OrderID")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("OrderModelId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientID");

                    b.HasIndex("OrderModelId");

                    b.HasIndex("ProductID");

                    b.ToTable("BasketProducts");
                });

            modelBuilder.Entity("MaisonEauOr.Models.DisplayModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.ToTable("DisplayedProducts");
                });

            modelBuilder.Entity("MaisonEauOr.Models.Option", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("MaisonEauOr.Models.OrderModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrderedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Payed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShippingAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ShippingPostalCode")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ShippingPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("ShippingTown")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ClientID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MaisonEauOr.Models.ProductModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("AmountInStock")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

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

                    b.Property<double>("Tva")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Products");
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

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DoubleAuth")
                        .HasColumnType("INTEGER");

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

            modelBuilder.Entity("MaisonEauOr.Models.BasketProductModel", b =>
                {
                    b.HasOne("MaisonEauOr.Models.UserAccount", "User")
                        .WithMany("BasketProducts")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MaisonEauOr.Models.OrderModel", null)
                        .WithMany("ProductIDs")
                        .HasForeignKey("OrderModelId");

                    b.HasOne("MaisonEauOr.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MaisonEauOr.Models.DisplayModel", b =>
                {
                    b.HasOne("MaisonEauOr.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MaisonEauOr.Models.OrderModel", b =>
                {
                    b.HasOne("MaisonEauOr.Models.UserAccount", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("MaisonEauOr.Models.OrderModel", b =>
                {
                    b.Navigation("ProductIDs");
                });

            modelBuilder.Entity("MaisonEauOr.Models.UserAccount", b =>
                {
                    b.Navigation("BasketProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
