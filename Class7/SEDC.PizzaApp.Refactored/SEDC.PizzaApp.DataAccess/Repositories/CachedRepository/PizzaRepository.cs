using System;
using System.Collections.Generic;
using System.Linq;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Repositories.CachedRepository
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public void DeleteById(int id)
        {
            Pizza pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);

            if (pizza != null)
            {
                StaticDB.Pizzas.Remove(pizza);
            }
        }

        public List<Pizza> GetAll()
        {
            return StaticDB.Pizzas;
        }

        public Pizza GetById(int id)
        {
            return StaticDB.Pizzas.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(Pizza entity)
        {
            StaticDB.PizzaId++;
            entity.Id = StaticDB.PizzaId;

            StaticDB.Pizzas.Add(entity);
        }

        public void Update(Pizza entity)
        {
            Pizza pizza = StaticDB.Pizzas.SingleOrDefault(x => x.Id == entity.Id);
            if (pizza != null)
            {
                pizza.Name = entity.Name;
                pizza.IsOnPromotion = entity.IsOnPromotion;
                pizza.Price = entity.Price;
                pizza.Size = entity.Size;
            }
        }
    }
}
