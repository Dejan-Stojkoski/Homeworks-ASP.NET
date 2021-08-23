using System.Collections.Generic;
using System.Linq;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Repositories.CachedRepository
{
    public class OrderRepository : IRepository<Order>
    {
        public void DeleteById(int id)
        {
            Order order = StaticDB.Orders.SingleOrDefault(x => x.Id == id);

            if (order != null)
            {
                StaticDB.Orders.Remove(order);
            }
        }

        public List<Order> GetAll()
        {
            return StaticDB.Orders;
        }

        public Order GetById(int id)
        {
            return StaticDB.Orders.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            StaticDB.OrdersId++;
            entity.Id = StaticDB.OrdersId;

            StaticDB.Orders.Add(entity);
        }

        public void Update(Order entity)
        {
            Order order = StaticDB.Orders.SingleOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                order.User = entity.User;
                order.Price = entity.Price;
                order.PizzaStore = entity.PizzaStore;
                order.Pizza = entity.Pizza;
                order.PaymentMethod = entity.PaymentMethod;
                order.Delivered = entity.Delivered;
            }
        }
    }
}
