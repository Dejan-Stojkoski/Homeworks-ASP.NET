using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Web.Models;

namespace SEDC.PizzaApp.Web.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDB.Pizzas;

            return new JsonResult(pizzas);
        }

        public IActionResult Details(int id)
        {
            if (StaticDB.Pizzas.Any(x => x.Id == id))
            {
                //return View();

                Pizza pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);

                return new JsonResult(pizza);
            }
            else
            {
                //return new EmptyResult();

                return RedirectToAction("Error", "Home");
            }
        }
    }
}
