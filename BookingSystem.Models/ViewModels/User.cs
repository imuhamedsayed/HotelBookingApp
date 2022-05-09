using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BookingSystem.BLL.ViewModels
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public IEnumerable<UserRooms> UserRooms { get; set; }

    }
}
