using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FoodDelivery.Models;

namespace FoodDelivery.DAL
{
    public class FoodDeliveryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FoodDeliveryContext>
    {
        protected override void Seed(FoodDeliveryContext context)
        {

            //System.Diagnostics.Trace.WriteLine("Started Here");
            var foodTypes = new List<FoodType>
            {
                new FoodType{ Id=1, Name="Cold" },
                new FoodType{ Id=2, Name="Hot" },
                new FoodType{ Id=3, Name="Pastry" },
                new FoodType{ Id=4, Name="Candy" },  
                new FoodType{ Id=5, Name="Oghrashuli" }
            };

            foodTypes.ForEach(s => context.FoodTypes.Add(s));
            context.SaveChanges();
            //System.Diagnostics.Trace.WriteLine("Foodtypes");
            var restaurantTypes = new List<RestaurantType>
            {
                new RestaurantType{Id=1, TypeName="Homey"},
                new RestaurantType{Id=2, TypeName="Georgian"},
                new RestaurantType{Id=3, TypeName="Indian"},
                new RestaurantType{Id=4, TypeName="Mexican"}
            };
            restaurantTypes.ForEach(s => context.RestaurantTypes.Add(s));
            context.SaveChanges();

            //Nothing Seemed to seed the database with restaurants, it was either
            // cannot insert null when inserting a datetime or cannot insert on primary key

            //System.Diagnostics.Trace.WriteLine("restTypes");
        /*
            context.Database.ExecuteSqlCommand("Insert into Restaurant(id, description, name, restauranttypeid, logourl, registerTime)" +
                "values (1, 'Greatest Mexican Restaurant in Universe', 'MExico',  4, 'https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg', GETDATE())");
            context.Database.ExecuteSqlCommand("Insert into Restaurant(id, description, name, restauranttypeid, logourl, registerTime)" +
               "values (2, 'Greatest Mexican Restaurant in Universe','GEOxico', 2, 'https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg', GETDATE())");
            context.Database.ExecuteSqlCommand("Insert into Restaurant(id, description, name, restauranttypeid, logourl, registerTime)" +
                           "values (3, 'Greatest Mexican Restaurant in Universe','Somethin Amazing', 1, 'https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg', GETDATE())");
            context.Database.ExecuteSqlCommand("Insert into Restaurant(id, description, name, restauranttypeid, logourl, registerTime)" +
                           "values (4, 'Greatest Mexican Restaurant in Universe','Super Food', 3, 'https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg', GETDATE())");

            /*var restaurants = new List<Restaurant>
            {
                new Restaurant{Type=restaurantTypes[2],  Id=1,Description="Greatest Mexican Restaurant in Universe", Name="EL MEXICO", RegisterTime=DateTime.Parse("1996/07/08"), LogoURL="https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg"},
                new Restaurant{Type=restaurantTypes[1],  Id=2,Description="Good Geo Food", Name="Shemoixede", RegisterTime=DateTime.Parse("1996/09/08"), LogoURL="https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg"},
                new Restaurant{Type=restaurantTypes[0],  Id=3,Description="Lovely Homemade Food", Name="HomeMadeFood", RegisterTime=DateTime.Parse("2006/07/08"), LogoURL="https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg"},
                new Restaurant{Type=restaurantTypes[3],  Id=4,Description="Bad Mexican Restaurant", Name="Indian Express", RegisterTime=DateTime.Parse("2016/09/09"), LogoURL="https://www.rd.com/wp-content/uploads/2018/04/9-Foods-You-Should-Never-Eat-Before-Bed-760x506.jpg"}
            };
            System.Diagnostics.Trace.WriteLine(restaurants[0].RegisterTime);
            restaurants.ForEach(s => context.Restaurants.Add(s));*/
          /*  context.SaveChanges();
            System.Diagnostics.Trace.WriteLine("restaurants");
            var food = new List<FoodItem>
            {
                new FoodItem{Id=1, Name="Khinkali", FoodTypeId=2, Price=0.8, RestaurantId=1, Time=15},
                new FoodItem{Id=2, Name="Fajitas", FoodTypeId=2, Price=0.8, RestaurantId=2, Time=10},
                new FoodItem{Id=3, Name="Burrito", FoodTypeId=2, Price=0.8, RestaurantId=3, Time=1},
                new FoodItem{Id=4, Name="Taco", FoodTypeId=2, Price=0.8, RestaurantId=4, Time=5},
                new FoodItem{Id=5, Name="Khinkali1", FoodTypeId=2, Price=0.8, RestaurantId=1, Time=7},
                new FoodItem{Id=6, Name="Khinkali2", FoodTypeId=2, Price=0.8, RestaurantId=2, Time=90},
                new FoodItem{Id=7, Name="Khinkali3", FoodTypeId=2, Price=0.8, RestaurantId=3, Time=100},
                new FoodItem{Id=8, Name="Khinkali4", FoodTypeId=2, Price=0.8, RestaurantId=4, Time=1},
                new FoodItem{Id=9, Name="Khinkali5", FoodTypeId=2, Price=0.8, RestaurantId=2, Time=5},
                new FoodItem{Id=10, Name="Khinkali6", FoodTypeId=2, Price=0.8, RestaurantId=2, Time=9},
                new FoodItem{Id=11, Name="Khinkali7", FoodTypeId=2, Price=0.8, RestaurantId=3, Time=7},
                new FoodItem{Id=12, Name="Khinkali8", FoodTypeId=2, Price=0.8, RestaurantId=4, Time=18}
            };
            food.ForEach(s => context.FoodItems.Add(s));
            System.Diagnostics.Trace.WriteLine("foooooood");
            context.SaveChanges();
            System.Diagnostics.Trace.WriteLine("Came HERE"); */ 
        }
    }
}