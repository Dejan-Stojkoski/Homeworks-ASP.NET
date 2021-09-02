using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using EStoreApp.DataAccess.Repositories;
using EStoreApp.Domain.Models;
using EStoreApp.Services.Services.Interfaces;

namespace EStoreApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _userRepository.GetAll().SingleOrDefault(x => x.Email == email && x.Password == password);
        }

        //public List<Claim> CreateUserClaims(string email, string password)
        //{
        //    var user = _userRepository.GetAll().SingleOrDefault(x => x.Email == email && x.Password == password);

        //    if(user != null)
        //    {
        //        List<Claim> claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, user.FirstName),
        //            new Claim("email", user.Email),
        //            new Claim("id", $"{user.Id}")
        //        };

        //        return claims;
        //    }

        //    return null;
        //}
    }
}
