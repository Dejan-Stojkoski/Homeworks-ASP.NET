using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Order> orders = StaticDB.Orders;

            List<OrderDetailsViewModel> orderDetailsViews = new List<OrderDetailsViewModel>();

            foreach(Order order in orders)
            {
                orderDetailsViews.Add(OrderMapper.OrderToOrderDetailsViewModel(order));
            }

            return View(orderDetailsViews);
        }
    }
}
