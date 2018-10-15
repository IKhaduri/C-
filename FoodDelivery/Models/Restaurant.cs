using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodDelivery.Models
{
    public class Restaurant
    {

        public int Id { get; set; }

        [Required]
        [DisplayName("Restaurant Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        

        [Required]
        [DisplayName("Logo")]
        public string LogoURL { get; set; }

        public int RestaurantTypeId { get; set; }
        public virtual RestaurantType Type { get; set; }

        public virtual ICollection<FoodItem> FoodItems { get; set; }

    }
}