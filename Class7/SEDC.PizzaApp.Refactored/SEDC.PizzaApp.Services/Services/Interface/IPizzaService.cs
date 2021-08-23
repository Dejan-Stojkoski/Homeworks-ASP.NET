using System.Collections.Generic;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.Services.Services.Interface
{
    public interface IPizzaService
    {
        List<Pizza> GetAllPizzas();
    }
}
