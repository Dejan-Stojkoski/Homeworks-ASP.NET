using System.Collections.Generic;
using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.Services.Services.Interface
{
    public interface IUserService
    {
        List<User> GetUsers();
        string GiveFeedback(Feedback feedback);
        List<Feedback> GetFeedback(int numberOfFeedbacks);
    }
}
