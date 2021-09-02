using System.Collections.Generic;
using EStoreApp.Domain.Enums;
using EStoreApp.Domain.Models;

namespace EStoreApp.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserStatus Status { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Order> Orders { get; set; }
    }
}
