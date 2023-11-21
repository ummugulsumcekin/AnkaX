using AnkaX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AnkaX.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "iOSApp", DisplayOrder = 1 },
                new Category { Id = 2, Name = "AndroidApp", DisplayOrder = 2 },
                new Category { Id = 3, Name = "iOSApp&AndroidApp", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(


new Product
{
    Id = 1,
    Title = "Type Now Keyboard Translator",
    Seller = "Pavel Pudau",
    Description = "Type Now is a translator application. We have high positions in the App Store in the US and UK. Traffic is only organic. Sales have not fallen for several years. ",
    SiteAge = "2 year",
    Industry = "Education",
    Location = "United Arab Emirates",
    MonthlyNetProfit = 15733,
    Price = 500000,
    CategoryId=1,
    ImageUrl=""

},

new Product
{
    Id = 2,
    Title = "Astroscope: Astrology & Horoscope App",
    Seller = "Vladyslav Vanyukhin",
    Description = "New astrology & horoscope app for Android & iOS in (2023) + 2M followers / Over 113,000 users in half a year / Beautiful design and $0 spent on marketing ",
    SiteAge = "<1 year",
    Industry = "Astrology",
    Location = "Poland",
    MonthlyNetProfit = 2958,
    Price = 400000,
    CategoryId = 3,
    ImageUrl = ""

},

new Product
{
    Id = 3,
    Title = "Cellular Network Signal Finder",
    Seller = "Giacomo Balli",
    Description = "Mobile app to find cell towers. Highly profitable, fully automated. Over a decade in business. ",
    SiteAge = "12 years",
    Industry = "Technology",
    Location = "United States",
    MonthlyNetProfit = 5941,
    Price = 249999,
    CategoryId = 1,
    ImageUrl = ""

},

new Product
{
    Id = 4,
    Title = "Real Thermometer +",
    Seller = "Oleg Chrsava",
    Description = "Real Thermometer+ is an IOS app that was launched in 2021. The app was created by an experienced team of developers, designers, ASO and marketing specialists. ",
    SiteAge = "1,5year",
    Industry = "Health",
    Location = "Latvia",
    MonthlyNetProfit = 2635,
    Price = 123500,
    CategoryId = 1,
    ImageUrl = ""

},

new Product
{
    Id = 5,
    Title = "Clear Spaces",
    Seller = "Mathew Nadeem",
    Description = "Clear Spaces is the original Transparent Widget app, very profitable with no running costs. Has been in the top charts since release.",
    SiteAge = "3",
    Industry = "Design and Style",
    Location = "United Kingdom",
    MonthlyNetProfit = 3244,
    Price = 110000,
    CategoryId = 2,
    ImageUrl = ""
},

new Product
{
    Id = 6,
    Title = "Mapi Games",
    Seller = "Giuseppe Indie",
    Description = "Bundle of 150+ Published Games",
    SiteAge = "11",
    Industry = "Game",
    Location = "Italy",
    MonthlyNetProfit = 854,
    Price = 90000,
    CategoryId = 2,
    ImageUrl = ""
}
                );
        }
    }
}
