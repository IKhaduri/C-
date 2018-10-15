using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FoodDelivery.Models;

namespace FoodDelivery.DAL
{
    public class FoodDeliveryContext : DbContext
    {
        public FoodDeliveryContext() : base("FoodDeliveryContext120")
        {
            Database.SetInitializer(new FoodDeliveryInitializer());
        }
        //Add new Dbsets here
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<RestaurantType> RestaurantTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}