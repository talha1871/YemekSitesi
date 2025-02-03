using Base_Model.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.Context
{
    public class SignalRContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L2KI7UE\\SQLEXPRESS;initial Catalog=SignalRDB;integrated Security=True");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-L2KI7UE\\SQLEXPRESS;Database=SignalRDB;Trusted_Connection = True;");


        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonial { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<MoneyCase> MoneyCases { get; set; }

        public DbSet<RestaurantTable> RestaurantTables { get; set; }

       public DbSet<Slider> Sliders { get; set; }
    }
}
