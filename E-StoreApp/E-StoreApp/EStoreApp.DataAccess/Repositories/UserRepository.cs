using System.Collections.Generic;
using System.Linq;
using EStoreApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreApp.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private EStoreDbContext _db;
        public UserRepository(EStoreDbContext db)
        {
            _db = db;
        }

        public void DeleteById(int id)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == id);
            if(user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            return _db.Users
                    .Include(x => x.Reviews)
                    .ThenInclude(x => x.Product)
                    .Include(x => x.Orders)
                    .ThenInclude(x => x.Products)
                    .ThenInclude(x => x.Product).ToList();
        }

        public User GetById(int id)
        {
            return _db.Users.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(User entity)
        {
            _db.Users.Add(entity);
            return _db.SaveChanges();
        }

        public void Update(User entity)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                entity.Id = user.Id;
                _db.Users.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
