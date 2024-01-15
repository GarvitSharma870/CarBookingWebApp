using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    Name = "User",
                    NormalizedName = "User"
                },
                new IdentityRole
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    Name = "Admin",
                    NormalizedName = "Admin"
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb0",
                    Name = "Admin",
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    Name = "User",
                    UserName = "admin2@gmail.com",
                    NormalizedUserName = "ADMIN2@GMAIL.COM",
                    Email = "admin2@gmail.com",
                    NormalizedEmail = "ADMIN2@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin2@123"),
                    LockoutEnabled = true
                }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb0"
            },
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            }
            );

            modelBuilder.Entity<Company>().HasData(
               new Company
               {
                   Id = 1,
                   CompanyName = "Hyundai",
                   CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb0",
                   CreatedOn = DateTime.Now
               },
            new Company
            {
                Id = 2,
                CompanyName = "Toyota",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb0",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 3,
                CompanyName = "Ford",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb0",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 4,
                CompanyName = "BMW",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb0",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 5,
                CompanyName = "Honda",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb0",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 6,
                CompanyName = "Chevrolet",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb0",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 7,
                CompanyName = "Mercedes-Benz",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 8,
                CompanyName = "Nissan",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 9,
                CompanyName = "Volkswagen",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                CreatedOn = DateTime.Now
            },
            new Company
            {
                Id = 10,
                CompanyName = "Tesla",
                CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                CreatedOn = DateTime.Now
            }
            );

            modelBuilder.Entity<CarBooking>()
                .HasOne(x => x.Company)
                .WithMany(x => x.Bookings)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<CarBooking>()
                .HasOne(x => x.Car)
                .WithMany(x => x.Bookings)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CarBooking>()
                .HasOne(x => x.User)
                .WithMany(x => x.BookedCars)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Car>()
                .HasOne(x => x.User)
                .WithMany(x => x.CarDetails)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Car>()
                .HasOne(x => x.Company)
                .WithMany(x => x.Cars)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Car>()
                .HasIndex(x => new { x.CarName, x.Number })
                .IsUnique();
            modelBuilder.Entity<TimeZone>().HasData(
                new TimeZone
                {
                    Id = 1,
                    TimeZoneName = "Pacific/Auckland (UTC +13:00)",
                    UTCOffset = "+13:00",
                    CreatedOn = DateTime.Now,
                    IsDeleted = false
                },
   new TimeZone
   {
       Id = 2,
       TimeZoneName = "Australia/Sydney (UTC +11:00)",
       UTCOffset = "+11:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 3,
       TimeZoneName = "Australia/Brisbane (UTC +10:00)",
       UTCOffset = "+10:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 4,
       TimeZoneName = "Asia/Hong_Kong (UTC +08:00)",
       UTCOffset = "+08:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 5,
       TimeZoneName = "Asia/Tokyo (UTC +09:00)",
       UTCOffset = "+09:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 6,
       TimeZoneName = "Europe/London (UTC +00:00)",
       UTCOffset = "+00:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 7,
       TimeZoneName = "America/New_York (UTC -05:00)",
       UTCOffset = "-05:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 8,
       TimeZoneName = "America/Los_Angeles (UTC -08:00)",
       UTCOffset = "-08:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 9,
       TimeZoneName = "Africa/Cairo (UTC +02:00)",
       UTCOffset = "+02:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 10,
       TimeZoneName = "India Standard Time (UTC +05:30)",
       UTCOffset = "+05:30",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 11,
       TimeZoneName = "America/Chicago (UTC -06:00)",
       UTCOffset = "-06:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 12,
       TimeZoneName = "Canada/Newfoundland (UTC -03:30)",
       UTCOffset = "-03:30",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 13,
       TimeZoneName = "Pacific/Fiji (UTC +12:00)",
       UTCOffset = "+12:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 14,
       TimeZoneName = "America/Denver (UTC -07:00)",
       UTCOffset = "-07:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   },
   new TimeZone
   {
       Id = 15,
       TimeZoneName = "Asia/Dubai (UTC +04:00)",
       UTCOffset = "+04:00",
       CreatedOn = DateTime.Now,
       IsDeleted = false
   }

           );

        }
    }
}
