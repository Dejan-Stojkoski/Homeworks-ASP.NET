using System;
using System.Collections.Generic;
using System.Linq;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Repositories.CachedRepository
{
    public class UserRepository : IRepository<User>
    {
        public void DeleteById(int id)
        {
            User user = StaticDB.Users.SingleOrDefault(x => x.Id == id);

            if(user != null)
            {
                StaticDB.Users.Remove(user);
            }
        }

        public List<User> GetAll()
        {
            return StaticDB.Users;
        }

        public User GetById(int id)
        {
            return StaticDB.Users.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(User entity)
        {
            StaticDB.UserId++;
            entity.Id = StaticDB.UserId;

            StaticDB.Users.Add(entity);
        }

        public void Update(User entity)
        {
            User user = StaticDB.Users.SingleOrDefault(x => x.Id == entity.Id);
            if(user != null)
            {
                user.FirstName = entity.FirstName;
                user.LastName = entity.LastName;
                user.Address = entity.Address;
                user.Phone = entity.Phone;
            }
        }
    }
}
