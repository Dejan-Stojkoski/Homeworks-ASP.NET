using System.Collections.Generic;
using System.Linq;
using EStoreApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreApp.DataAccess.Repositories
{
    public class ReviewRepository : IRepository<Review>
    {
        private EStoreDbContext _db;
        public ReviewRepository(EStoreDbContext db)
        {
            _db = db;
        }

        public void DeleteById(int id)
        {
            var review = _db.Reviews.SingleOrDefault(x => x.Id == id);
            if(review != null)
            {
                _db.Reviews.Remove(review);
                _db.SaveChanges();
            }
        }

        public List<Review> GetAll()
        {
            return _db.Reviews
                    .Include(x => x.Product)
                    .Include(x => x.User).ToList();
        }

        public Review GetById(int id)
        {
            return _db.Reviews.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Review entity)
        {
            _db.Reviews.Add(entity);
            return _db.SaveChanges();
        }

        public void Update(Review entity)
        {
            var review = _db.Reviews.SingleOrDefault(x => x.Id == entity.Id);
            if (review != null)
            {
                entity.Id = review.Id;
                _db.Reviews.Update(entity);
                _db.SaveChanges();
            }
        }
    }
}
