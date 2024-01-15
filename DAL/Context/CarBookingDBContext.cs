using DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeZone = DAL.Entities.TimeZone;

namespace DAL.Context
{
    public class CarBookingDBContext : IdentityDbContext<User>
    {
        public CarBookingDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
        public DbSet<User> Users {  get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBooking> Bookings { get; set;}
        public DbSet<TimeZone> TimeZones { get; set; }
    }
}
