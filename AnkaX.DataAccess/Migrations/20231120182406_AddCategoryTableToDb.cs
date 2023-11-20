using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnkaX.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Seller = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    SiteAge = table.Column<string>(type: "TEXT", nullable: false),
                    Industry = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    MonthlyNetProfit = table.Column<double>(type: "REAL", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "iOSApp" },
                    { 2, 2, "AndroidApp" },
                    { 3, 3, "iOSApp&AndroidApp" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Industry", "Location", "MonthlyNetProfit", "Price", "Seller", "SiteAge", "Title" },
                values: new object[,]
                {
                    { 1, "Type Now is a translator application. We have high positions in the App Store in the US and UK. Traffic is only organic. Sales have not fallen for several years. ", "Education", "United Arab Emirates", 15733.0, 500000.0, "Pavel Pudau", "2 year", "Type Now Keyboard Translator" },
                    { 2, "New astrology & horoscope app for Android & iOS in (2023) + 2M followers / Over 113,000 users in half a year / Beautiful design and $0 spent on marketing ", "Astrology", "Poland", 2958.0, 400000.0, "Vladyslav Vanyukhin", "<1 year", "Astroscope: Astrology & Horoscope App" },
                    { 3, "Mobile app to find cell towers. Highly profitable, fully automated. Over a decade in business. ", "Technology", "United States", 5941.0, 249999.0, "Giacomo Balli", "12 years", "Cellular Network Signal Finder" },
                    { 4, "Real Thermometer+ is an IOS app that was launched in 2021. The app was created by an experienced team of developers, designers, ASO and marketing specialists. ", "Health", "Latvia", 2635.0, 123500.0, "Oleg Chrsava", "1,5year", "Real Thermometer +" },
                    { 5, "Clear Spaces is the original Transparent Widget app, very profitable with no running costs. Has been in the top charts since release.", "Design and Style", "United Kingdom", 3244.0, 110000.0, "Mathew Nadeem", "3", "Clear Spaces" },
                    { 6, "Bundle of 150+ Published Games", "Game", "Italy", 854.0, 90000.0, "Giuseppe Indie", "11", "Mapi Games" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
