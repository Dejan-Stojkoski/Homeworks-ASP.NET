﻿using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.ViewModels;

namespace SEDC.PizzaApp.Web.Models.Mapper
{
    public static class PizzaMapper
    {
        public static PizzaDetailsViewModel PizzaToPizzaDetailsViewModel (this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
    }
}
