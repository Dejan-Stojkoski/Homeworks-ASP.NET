﻿using System.Collections.Generic;
using System.Linq;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Enums;

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
                IsOnPromotion = true,
                Price = 7,
                PizzaSize = PizzaSize.Normal,
                HasExtras = true
            },
            new Pizza
            {
                Id = 2,
                Name = "Napolitana",
                IsOnPromotion = false,
                Price = 3,
                PizzaSize = PizzaSize.Family,
                HasExtras = false
            },
            new Pizza
            {
                Id = 3,
                Name = "Capri",
                IsOnPromotion = false,
                Price = 4,
                PizzaSize = PizzaSize.Family,
                HasExtras = true
            }
        };

        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Jon",
                LastName = "Smith",
                Address = "Partizanska bb",
                Phone = 111222333
            },
            new User
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                Address = "Partizanska br.19",
                Phone = 111122222
            },
             new User
            {
                Id = 3,
                FirstName = "Alex",
                LastName = "Smith",
                Address = "Varshavska br.13",
                Phone = 123456789
            }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                PaymentMethod = PaymentMethod.Card,
                User = Users.First(),
                Pizza = Pizzas.First(),
                Price = Pizzas.First().Price,
                Delivered = true,
                PizzaStore = "Jakomo"
            },
            new Order
            {
                Id = 2,
                PaymentMethod = PaymentMethod.Cash,
                User = Users.FirstOrDefault(x => x.Id == 2),
                Pizza = Pizzas.FirstOrDefault(x => x.Id == 2),
                Price = Pizzas.FirstOrDefault(x => x.Id == 2).Price,
                Delivered = false,
                PizzaStore = "Mama Italiana"
            },
            new Order
            {
                Id = 3,
                PaymentMethod = PaymentMethod.Card,
                User = Users.Last(),
                Pizza = Pizzas.Last(),
                Price = Pizzas.Last().Price,
                Delivered = false,
                PizzaStore = "Dominos"
            }
        };
    }
}
