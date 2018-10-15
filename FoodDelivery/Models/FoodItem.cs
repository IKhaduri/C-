using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodDelivery.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [DisplayName("Cooking Time")]
        public int Time { get; set; }
        [Required]
        [DisplayName("Food Name")]
        public string Name { get; set; }

        [DisplayName("Food Type")]
        public int FoodTypeId { get; set; }
        [DisplayName("Food Type")]
        public virtual FoodType FoodType { get; set; }

        [DisplayName("Restaurant")]
        public int RestaurantId { get; set; }
        [DisplayName("Restaurant")]
        public virtual Restaurant Restaurant { get; set; }

    }
}