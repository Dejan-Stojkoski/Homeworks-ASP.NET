using System.Collections.Generic;
using System.Linq;
using EStoreApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreApp.DataAccess.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private EStoreDbContext _db;
        public OrderRepository(EStoreDbContext db)
        {
            _db = db;
        }

        public void DeleteById(int id)
        {
            var order = _db.Orders.SingleOrDefault(x => x.Id == id);
            if(order != null)
            {
                _db.Orders.Remove(order);
                _db.SaveChanges();
            }
        }

        public List<Order> GetAll()
        {
            return _db.Orders
                .Include(x => x.User)
                .Include(x => x.Products)
                .ThenInclude(x => x.Product).ToList();
        }

        public Order GetById(int id)
        {
            return _db.Orders.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Order entity)
        {
            _db.Orders.Add(entity);
            return _db.SaveChanges();
        }

        public void Update(Order entity)
        {
            var order = _db.Orders.SingleOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                entity.Id = order.Id;
                _db.Orders.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
