using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models.Domain;
using SEDC.PizzaApp.Web.Models.Mapper;
using SEDC.PizzaApp.Web.Models.ViewModels;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<PizzaDetailsViewModel> pizzaViewList = new List<PizzaDetailsViewModel>();

            StaticDB.Pizzas.ForEach(x => pizzaViewList.Add(x.PizzaToPizzaDetailsViewModel()));

            ViewData.Add("Title", "Pizzas");
            return View(pizzaViewList);
        }

        public IActionResult Details(int id)
        {
            if (StaticDB.Pizzas.Any(x => x.Id == id))
            {
                Pizza pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);
                PizzaDetailsViewModel pizzaView = pizza.PizzaToPizzaDetailsViewModel();

                ViewData.Add("Title", "Details for the chosen pizza");
                return View(pizzaView);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
