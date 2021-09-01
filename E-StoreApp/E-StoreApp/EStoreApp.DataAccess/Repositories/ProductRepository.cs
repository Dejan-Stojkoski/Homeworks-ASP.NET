using System.Collections.Generic;
using System.Linq;
using EStoreApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreApp.DataAccess.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private EStoreDbContext _db;
        public ProductRepository(EStoreDbContext db)
        {
            _db = db;
        }

        public void DeleteById(int id)
        {
            var product = _db.Products.SingleOrDefault(x => x.Id == id);
            if(product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            return _db.Products.Include(x => x.Reviews).ToList();
        }

        public Product GetById(int id)
        {
            return _db.Products.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Product entity)
        {
            _db.Products.Add(entity);
            return _db.SaveChanges();
        }

        public void Update(Product entity)
        {
            var product = _db.Products.SingleOrDefault(x => x.Id == entity.Id);
            if (product != null)
            {
                entity.Id = product.Id;
                _db.Products.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
