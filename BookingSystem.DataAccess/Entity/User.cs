using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.DAL.Entity
{
    public class User : IdentityUser
    {
        public string Role { get; set; }
        [NotMapped]
        public string Token { get; set; }
        public IEnumerable<UserRooms> UserRooms { get; set; }
    }
}
