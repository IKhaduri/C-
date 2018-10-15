using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FoodDelivery.Models
{
    public class RestaurantType
    {
        public int Id { get; set; }
        [DisplayName("Type")]
        public string TypeName { get; set; }

        public virtual IEnumerable<Restaurant> Restaurants {get; set;}
    }
}