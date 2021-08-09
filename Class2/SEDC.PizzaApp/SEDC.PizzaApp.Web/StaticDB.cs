using System;
using System.Collections.Generic;
using SEDC.PizzaApp.Web.Models;

namespace SEDC.PizzaApp.Web
{
    public class StaticDB
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = "Margarita",
                IsOnPromotion = true
            },
            new Pizza
            {
                Id = 2,
                Name = "Napolitana",
                IsOnPromotion = false
            },
            new Pizza
            {
                Id = 3,
                Name = "Capri",
                IsOnPromotion = false
            }
        };
    }
}
