using System.ComponentModel.DataAnnotations;

namespace BookingSystem.BLL.ViewModels
{
    public class AuthModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
