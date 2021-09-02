using EStoreApp.Domain.Models;

namespace EStoreApp.Web.Models.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel UserToUserViewModel( User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                Email = user.Email,
                Status = user.Status,
                Orders = user.Orders,
                Reviews = user.Reviews
            };
        }
    }
}
