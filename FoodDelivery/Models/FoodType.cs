using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FoodDelivery.Models
{
    public class FoodType
    {
        public int Id { get; set; }

        [DisplayName("Food Type")]
        public string Name { get; set; }

        public virtual IEnumerable<FoodItem> FoodItems { get; set; }
    }
}