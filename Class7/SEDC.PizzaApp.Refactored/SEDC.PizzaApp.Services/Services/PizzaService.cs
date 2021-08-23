using System.Collections.Generic;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interface;

namespace SEDC.PizzaApp.Services.Services
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepository;

        public PizzaService(IRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public List<Pizza> GetAllPizzas()
        {
            return _pizzaRepository.GetAll();
        }
    }
}
