using System.Collections.Generic;
using System.Security.Claims;
using EStoreApp.Domain.Models;

namespace EStoreApp.Services.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserByEmailAndPassword(string email, string password);
        //List<Claim> CreateUserClaims(string username, string password);
    }
}
