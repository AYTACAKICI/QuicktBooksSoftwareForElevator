using ElevatorProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.DataAccessLayer.Concrete
{
   public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =AYTACAKICI\\SQLEXPRESS ; initial catalog=ElevatorDb;integrated security=true ");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            builder.Entity<Offer>()
                .Property(x => x.Price)
                .IsRequired(false);
            builder.Entity<Offer>()
                .Property(x => x.DateOfSubmitionOfOffer)
                .IsRequired(false);
            builder.Entity<Offer>()
                .Property(x => x.NumberOfFloor)
                .IsRequired(false);
            base.OnModelCreating(builder);
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<BreakdownRecord> BreakdownRecords { get; set; }
        public DbSet<BuildingManager> BuildingManagers { get; set; }
        public DbSet<Elevator> Elevators { get; set; }
        public DbSet<PeriodicMaintaince> PeriodicMaintainces { get; set; }
        public DbSet<Revision> Revisions { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<MessageCategory> MessageCategories { get; set; }
        public DbSet<Offer> Offers { get; set; }


    }
}
