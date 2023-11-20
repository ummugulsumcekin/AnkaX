﻿// <auto-generated />
using AnkaX.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnkaX.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231120182406_AddCategoryTableToDb")]
    partial class AddCategoryTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("AnkaX.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "iOSApp"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "AndroidApp"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "iOSApp&AndroidApp"
                        });
                });

            modelBuilder.Entity("AnkaX.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("MonthlyNetProfit")
                        .HasColumnType("REAL");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Seller")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteAge")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Type Now is a translator application. We have high positions in the App Store in the US and UK. Traffic is only organic. Sales have not fallen for several years. ",
                            Industry = "Education",
                            Location = "United Arab Emirates",
                            MonthlyNetProfit = 15733.0,
                            Price = 500000.0,
                            Seller = "Pavel Pudau",
                            SiteAge = "2 year",
                            Title = "Type Now Keyboard Translator"
                        },
                        new
                        {
                            Id = 2,
                            Description = "New astrology & horoscope app for Android & iOS in (2023) + 2M followers / Over 113,000 users in half a year / Beautiful design and $0 spent on marketing ",
                            Industry = "Astrology",
                            Location = "Poland",
                            MonthlyNetProfit = 2958.0,
                            Price = 400000.0,
                            Seller = "Vladyslav Vanyukhin",
                            SiteAge = "<1 year",
                            Title = "Astroscope: Astrology & Horoscope App"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Mobile app to find cell towers. Highly profitable, fully automated. Over a decade in business. ",
                            Industry = "Technology",
                            Location = "United States",
                            MonthlyNetProfit = 5941.0,
                            Price = 249999.0,
                            Seller = "Giacomo Balli",
                            SiteAge = "12 years",
                            Title = "Cellular Network Signal Finder"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Real Thermometer+ is an IOS app that was launched in 2021. The app was created by an experienced team of developers, designers, ASO and marketing specialists. ",
                            Industry = "Health",
                            Location = "Latvia",
                            MonthlyNetProfit = 2635.0,
                            Price = 123500.0,
                            Seller = "Oleg Chrsava",
                            SiteAge = "1,5year",
                            Title = "Real Thermometer +"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Clear Spaces is the original Transparent Widget app, very profitable with no running costs. Has been in the top charts since release.",
                            Industry = "Design and Style",
                            Location = "United Kingdom",
                            MonthlyNetProfit = 3244.0,
                            Price = 110000.0,
                            Seller = "Mathew Nadeem",
                            SiteAge = "3",
                            Title = "Clear Spaces"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Bundle of 150+ Published Games",
                            Industry = "Game",
                            Location = "Italy",
                            MonthlyNetProfit = 854.0,
                            Price = 90000.0,
                            Seller = "Giuseppe Indie",
                            SiteAge = "11",
                            Title = "Mapi Games"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
