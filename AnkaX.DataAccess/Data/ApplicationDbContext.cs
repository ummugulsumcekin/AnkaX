 using AnkaX.Models;
using AnkaX.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AnkaX.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "iOSApp", DisplayOrder = 1 },
                new Category { Id = 2, Name = "AndroidApp", DisplayOrder = 2 },
                new Category { Id = 3, Name = "iOSApp&AndroidApp", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "AppBusinessBrokers Tech Solution",
                    StreetAddress = "123 Tech St",
                    City = "New Mexico",
                    PostalCode = "12121",
                    State = "Mexico",
                    PhoneNumber = "6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "Fih.com",
                    StreetAddress = "30 Cornelia Street New York, NY",
                    City = "Manhattan",
                    PostalCode = "10014",
                    State = "United States",
                    PhoneNumber = "7779990000"
                },
                new Company
                {
                    Id = 3,
                    Name = "AI Club",
                    StreetAddress = "999 Main St",
                    City = "London",
                    PostalCode = "99999",
                    State = "UK",
                    PhoneNumber = "1113335555"
                }
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
