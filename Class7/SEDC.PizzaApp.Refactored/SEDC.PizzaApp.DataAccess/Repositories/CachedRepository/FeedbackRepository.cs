using System.Collections.Generic;
using System.Linq;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Repositories.CachedRepository
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        public void DeleteById(int id)
        {
            Feedback feedback = StaticDB.Feedbacks.SingleOrDefault(x => x.Id == id);

            if (feedback != null)
            {
                StaticDB.Feedbacks.Remove(feedback);
            }
        }

        public List<Feedback> GetAll()
        {
            return StaticDB.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            return StaticDB.Feedbacks.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(Feedback entity)
        {
            StaticDB.FeedbacksId++;
            entity.Id = StaticDB.FeedbacksId;

            StaticDB.Feedbacks.Add(entity);
        }

        public void Update(Feedback entity)
        {
            Feedback feedback = StaticDB.Feedbacks.SingleOrDefault(x => x.Id == entity.Id);
            if (feedback != null)
            {
                feedback.Name = entity.Name;
                feedback.Message = entity.Message;
                feedback.Email = entity.Email;
            }
        }
    }
}
