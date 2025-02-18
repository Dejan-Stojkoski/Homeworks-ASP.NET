﻿using SEDC.PizzaApp.Web.Models.Enums;

namespace SEDC.PizzaApp.Web.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PizzaName { get; set; }
        public string UserFullname { get; set; }
        public double Price { get; set; }
        public string UserAddress { get; set; }
    }
}
