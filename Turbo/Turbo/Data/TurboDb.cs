using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo.Models;

namespace Turbo.Data
{
    public class TurboDb : IdentityDbContext<CustomUser>
    {
        public TurboDb(DbContextOptions<TurboDb> options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<SpeedControl> SpeedControls { get; set; }
        public DbSet<AutoPhoto> AutoPhotos { get; set; }
        public DbSet<Automobile> Automobiles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<NewsPost> NewsPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "BMW"},
                new Brand { Id = 2, Name = "Mercedes" },
                new Brand { Id = 3, Name = "Nissan" },
                new Brand { Id = 4, Name = "Chevrolet" },
                new Brand { Id = 5, Name = "Ford" },
                new Brand { Id = 6, Name = "Toyota" },
                new Brand { Id = 7, Name = "Hyundai" },
                new Brand { Id = 8, Name = "Mitsubishi" },
                new Brand { Id = 9, Name = "Volkswagen" },
                new Brand { Id = 10, Name = "Lexus" }
            );

            builder.Entity<Model>().HasData(
                new Model { Id = 1, Name = "X-Trail", BrandId = 3  },
                new Model { Id = 2, Name = "Sunny", BrandId = 3 },
                new Model { Id = 3, Name = "Navara", BrandId = 3 },
                new Model { Id = 4, Name = "GL-500", BrandId = 2 },
                new Model { Id = 5, Name = "E-500", BrandId = 2 },
                new Model { Id = 6, Name = "X6", BrandId = 1 },
                new Model { Id = 7, Name = "M5", BrandId = 1 },
                new Model { Id = 8, Name = "Z4", BrandId = 1 },
                new Model { Id = 9, Name = "Camaro", BrandId = 4 },
                new Model { Id = 10, Name = "Cruze", BrandId = 4 },
                new Model { Id = 11, Name = "Niva", BrandId = 4 },
                new Model { Id = 12, Name = "Aveo", BrandId = 4 },
                new Model { Id = 13, Name = "Focus", BrandId = 5 },
                new Model { Id = 14, Name = "Mustang", BrandId = 5 },
                new Model { Id = 15, Name = "Avalon", BrandId = 6 },
                new Model { Id = 16, Name = "Carolla", BrandId = 6 },
                new Model { Id = 17, Name = "Grandis", BrandId = 8 },
                new Model { Id = 18, Name = "Galant", BrandId = 8 },
                new Model { Id = 19, Name = "Beetle", BrandId = 9 },
                new Model { Id = 20, Name = "GS-350", BrandId = 10 },
                new Model { Id = 21, Name = "UX-200", BrandId = 10 },
                new Model { Id = 22, Name = "S-600", BrandId = 2 },
                new Model { Id = 23, Name = "Camry", BrandId = 6 },
                new Model { Id = 24, Name = "Passat", BrandId = 9 },
                new Model { Id = 25, Name = "i40", BrandId = 7 },
                new Model { Id = 26, Name = "Accent", BrandId = 7 }
            );

            builder.Entity<Color>().HasData(
                new Color { Id = 1, Name = "Ağ" },
                new Color { Id = 2, Name = "Bənövşəyi" },
                new Color { Id = 3, Name = "Boz" },
                new Color { Id = 4, Name = "Çəhrayı" },
                new Color { Id = 5, Name = "Göy" },
                new Color { Id = 6, Name = "Narıncı" },
                new Color { Id = 7, Name = "Gümüşü" },
                new Color { Id = 8, Name = "Mavi" },
                new Color { Id = 9, Name = "Qara" },
                new Color { Id = 10, Name = "Qəhvəyi" },
                new Color { Id = 11, Name = "Qırmızı" },
                new Color { Id = 12, Name = "Qızılı" },
                new Color { Id = 13, Name = "Sarı" },
                new Color { Id = 14, Name = "Yaş Asfalt" },
                new Color { Id = 15, Name = "Yaşıl" }
            );

            builder.Entity<Fuel>().HasData(
                new Fuel { Id = 1, Name = "Benzin" },
                new Fuel { Id = 2, Name = "Dizel" },
                new Fuel { Id = 3, Name = "Qaz" },
                new Fuel { Id = 4, Name = "Elektro" },
                new Fuel { Id = 5, Name = "Hibrid" }
            );

            builder.Entity<SpeedControl>().HasData(
                new SpeedControl { Id = 1, Name = "Mexaniki" },
                new SpeedControl { Id = 2, Name = "Avtomat" }
            );

            builder.Entity<Automobile>().HasData(
                new Automobile { Id = 1, MainPhotoURL = "33145_GoTuNDe2_1Hci2mf8rS0uw.jpg", Price = 20000, ModelId = 1, Year = new DateTime(2019,08,06), Motor = 9000, Distance = 25000, ColorId = 11, FuelId = 1, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür." },
                new Automobile { Id = 2, MainPhotoURL = "67038_381FSTlcAuGmqGQgjqbYMg.jpg", Price = 20000, ModelId = 2, Year = new DateTime(2019,08,06), Motor = 9000, Distance = 25000, ColorId = 12, FuelId = 5, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür." },
                new Automobile { Id = 3, MainPhotoURL = "15000_Vho1XKv9QZ_a5HbeoPjDKQ.jpg", Price = 20000, ModelId = 4, Year = new DateTime(2019,08,06), Motor = 9000, Distance = 25000, ColorId = 13, FuelId = 2, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür." },
                new Automobile { Id = 4, MainPhotoURL = "66422_denAN4P_5rj8A-92CBxoDg.jpg", Price = 20000, ModelId = 3, Year = new DateTime(2019,08,06), Motor = 9000, Distance = 25000, ColorId = 14, FuelId = 4, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür." },
                new Automobile { Id = 5, MainPhotoURL = "51152_I9gRDA5diO-eB-RtZCnceA.jpg", Price = 20000, ModelId = 10, Year = new DateTime(2019,08,06), Motor = 9000, Distance = 25000, ColorId = 15, FuelId = 3, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür." },
                new Automobile { Id = 6, MainPhotoURL = "43207_n_Wut51cleHe07LUbJr5xA.jpg", Price = 20000, ModelId = 9, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 1, FuelId = 3, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 7, MainPhotoURL = "70050_4G0sJsd6Rj0oHMODwYfznw.jpg", Price = 20000, ModelId = 9, Year = new DateTime(2019,08,06), Motor = 9000, Distance = 25000, ColorId = 2, FuelId = 3, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür." },
                new Automobile { Id = 8, MainPhotoURL = "23323_JObOb4nGSseXgiQwIgNz3g.jpg", Price = 20000, ModelId = 9, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 3, FuelId = 1, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 9, MainPhotoURL = "12365_Fg7VfwJWa9t4Vj0ytGwz7Q.jpg", Price = 20000, ModelId = 8, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 4, FuelId = 1, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 10, MainPhotoURL = "87348_dKIhlYqS5IrdKUMvRd5Ivg.jpg", Price = 20000, ModelId = 3, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 5, FuelId = 1, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 11, MainPhotoURL = "60461_f2BISM8F-s8ju9poz1lfYw.jpg", Price = 20000, ModelId = 5, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 6, FuelId = 1, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 12, MainPhotoURL = "75569_8HIZ1tMLO55qUma60s5mrQ.jpg", Price = 20000, ModelId = 5, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 7, FuelId = 2, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 13, MainPhotoURL = "60461_gVWXF6f9RQH-aL2rWq7KOw.jpg", Price = 20000, ModelId = 2, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 8, FuelId = 2, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 14, MainPhotoURL = "60461_H7loK1K_Yahr6uSFbrn6ew.jpg", Price = 20000, ModelId = 7, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 9, FuelId = 5, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 15, MainPhotoURL = "87360_1OqT7-GeTXepqeuzWXLP6g.jpg", Price = 20000, ModelId = 6, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 10, FuelId = 3, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 16, MainPhotoURL = "60467_NKiaoEWoQOcGsnK9iFveHA.jpg", Price = 20000, ModelId = 1, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 11, FuelId = 4, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 17, MainPhotoURL = "43731_GTg_M--EPHYg9gSOYzN-aQ.jpg", Price = 20000, ModelId = 2, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 12, FuelId = 5, SpeedControlId = 2, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 18, MainPhotoURL = "60469_wri7h82Ga9pVtu4-JSmKnw.jpg", Price = 20000, ModelId = 3, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 13, FuelId = 5, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 19, MainPhotoURL = "67383_HPpLv_MRWn7arkJp_nhk8g.jpg", Price = 20000, ModelId = 3, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 14, FuelId = 2, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."},
                new Automobile { Id = 20, MainPhotoURL = "58760_3nFpzrKv9mqLAg155HhKnQ.jpg", Price = 20000, ModelId = 10, Year = new DateTime(2019,08,06), Motor =  9000, Distance = 25000, ColorId = 15, FuelId = 2, SpeedControlId = 1, ShortInfo = "Əla maşındır", FullInfo = "Saz vəziyyətdədir. Ciddi şəxslər əlaqə saxlasın. Endirim mümkündür."}
            );

            builder.Entity<AutoPhoto>().HasData(
                new AutoPhoto { Id = 1, PhotoURL = "2F5238_xBQPbBFrgTl3N58mkhH2aQ.jpg", AutomobileId = 1 },
                new AutoPhoto { Id = 2, PhotoURL = "2F33145_XZnjox0Y9H7xB5NtUj3aVg.jpg", AutomobileId = 1 },
                new AutoPhoto { Id = 3, PhotoURL = "2F99902_UOZjBj_8RJaljvtbYB9U-Q.jpg", AutomobileId = 2 },
                new AutoPhoto { Id = 4, PhotoURL = "2F67040_ubZwwgxdPCJksE-izaLWEw.jpg", AutomobileId = 2 },
                new AutoPhoto { Id = 5, PhotoURL = "2F67037_OgOY9xRmx02HvuzHlgdi4A.jpg", AutomobileId = 2 },
                new AutoPhoto { Id = 6, PhotoURL = "2F67383_bcdF1iQcKvfS8pVNQji1jA.jpg", AutomobileId = 10 },
                new AutoPhoto { Id = 7, PhotoURL = "2F87369_5Wa45uatwG2YWrWeaeSJdg.jpg", AutomobileId = 10 },
                new AutoPhoto { Id = 8, PhotoURL = "2F60461_aTzsAiks7vfApZfBHNQkIg.jpg", AutomobileId = 12 },
                new AutoPhoto { Id = 9, PhotoURL = "2F60465__-xfUAcrDjwm1_wCDuXnQg.jpg", AutomobileId = 12 },
                new AutoPhoto { Id = 10, PhotoURL = "2F60469_gc4d6VeTIMxUQzgcuuX7Zg.jpg", AutomobileId = 12 }
            );


            builder.Entity<Location>().HasData(
                new Location { Id = 1, Name = "Abşeron" },
                new Location { Id = 2, Name = "Ağcabədi" },
                new Location { Id = 3, Name = "Bakı" },
                new Location { Id = 4, Name = "Biləsuvar" },
                new Location { Id = 5, Name = "Cəlilabad" },
                new Location { Id = 6, Name = "Daşkəsən" },
                new Location { Id = 7, Name = "İmişli" },
                new Location { Id = 8, Name = "Hacıqabul" },
                new Location { Id = 9, Name = "Mingəçevir" },
                new Location { Id = 10, Name = "Naxçıvan" }
            );

            builder.Entity<Announcement>().HasData(
                new Announcement { Id = 1,  AutomobileId = 1, PublishDate = new DateTime(2019,08,06), LocationId = 10, IsVIP = true },
                new Announcement { Id = 2,  AutomobileId = 2, PublishDate = new DateTime(2019,08,06), LocationId = 7, IsVIP = true },
                new Announcement { Id = 3,  AutomobileId = 9, PublishDate = new DateTime(2019,08,06), LocationId = 3, IsVIP = true },
                new Announcement { Id = 4,  AutomobileId = 7, PublishDate = new DateTime(2018,08,06), LocationId = 8, IsVIP = true },
                new Announcement { Id = 5,  AutomobileId = 3, PublishDate = new DateTime(2018,08,06), LocationId = 1, IsVIP = true },
                new Announcement { Id = 6,  AutomobileId = 4, PublishDate = new DateTime(2018,08,06), LocationId = 2, IsVIP = true },
                new Announcement { Id = 7,  AutomobileId = 5, PublishDate = new DateTime(2018,08,06), LocationId = 2, IsVIP = true },
                new Announcement { Id = 8,  AutomobileId = 6, PublishDate = new DateTime(2017,08,06), LocationId = 2, IsVIP = true },
                new Announcement { Id = 9,  AutomobileId = 8, PublishDate = new DateTime(2017,08,06), LocationId = 4, IsVIP = true },
                new Announcement { Id = 10, AutomobileId = 14, PublishDate = new DateTime(2017,08,06), LocationId = 4, IsVIP = false },
                new Announcement { Id = 11, AutomobileId = 20, PublishDate = new DateTime(2017,08,06), LocationId = 6, IsVIP = false },
                new Announcement { Id = 12, AutomobileId = 13, PublishDate = new DateTime(2017,08,06), LocationId = 10, IsVIP = false },
                new Announcement { Id = 13, AutomobileId = 17, PublishDate = new DateTime(2016,08,06), LocationId = 10, IsVIP = false },
                new Announcement { Id = 14, AutomobileId = 20, PublishDate = new DateTime(2016,08,06), LocationId = 10, IsVIP = false },
                new Announcement { Id = 15, AutomobileId = 16, PublishDate = new DateTime(2016,08,06), LocationId = 3, IsVIP = false },
                new Announcement { Id = 16, AutomobileId = 20, PublishDate = new DateTime(2016,08,06), LocationId = 3, IsVIP = false },
                new Announcement { Id = 17, AutomobileId = 11, PublishDate = new DateTime(2016,08,06), LocationId = 5, IsVIP = false },
                new Announcement { Id = 18, AutomobileId = 12, PublishDate = new DateTime(2016,07,26), LocationId = 5, IsVIP = false },
                new Announcement { Id = 19, AutomobileId = 14, PublishDate = new DateTime(2016,07,16), LocationId = 7, IsVIP = false },
                new Announcement { Id = 20, AutomobileId = 11, PublishDate = new DateTime(2016,07,06), LocationId = 5, IsVIP = false }
            );

            builder.Entity<NewsPost>().HasData(
                new NewsPost { Id = 1, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) },
                new NewsPost { Id = 2, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) },
                new NewsPost { Id = 3, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) },
                new NewsPost { Id = 4, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) },
                new NewsPost { Id = 5, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) },
                new NewsPost { Id = 6, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) },
                new NewsPost { Id = 7, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) },
                new NewsPost { Id = 8, PhotoURL = "2268_YN6kwuhS4v4ARvpPWj2Lwg.jpg", Title = "Avtomobil dünyasında yenilik", ShortInfo = "Su ilə çalışan avtomobillər meydana gəlir.", MainArticle = "Rəsmi açıqlanması ilin sonuna planlaşdırılan su ilə çalışan avtomobillər Çinin Pekin şəhərində istehsal olunacaq. Mütəxəssislər düşünür ki, bu avtomobillərin ixtira olunması ətraf mühitin qorunmasında başlıca rol oynayacaq.", PublishDate = new DateTime(2019,08,06) }
            );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
