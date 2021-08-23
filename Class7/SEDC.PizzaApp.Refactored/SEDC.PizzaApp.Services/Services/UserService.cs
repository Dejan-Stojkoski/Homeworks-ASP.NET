using System.Collections.Generic;
using System.Linq;
using SEDC.PizzaApp.DataAccess.Repositories;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Services.Interface;

namespace SEDC.PizzaApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IRepository<Feedback> _feedbackRepository;
        public UserService(IRepository<User> userRepository, IRepository<Feedback> feedbackRepository)
        {
            _userRepository = userRepository;
            _feedbackRepository = feedbackRepository;
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public List<Feedback> GetFeedback(int numberOfFeedbacks)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll();

            if(feedbacks.Count > 0 && feedbacks.Count < numberOfFeedbacks && numberOfFeedbacks > 0)
            {
                return feedbacks.Take(numberOfFeedbacks).ToList();
            }

            return null;
        }

        public string GiveFeedback(Feedback feedback)
        {
            if(feedback != null)
            {
                _feedbackRepository.Insert(feedback);
                return "Thank you for your feedback!";
            }

            return "Something went wrong. Please try again!";
        }
    }
}
