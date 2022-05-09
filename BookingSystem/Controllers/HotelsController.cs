using BookingSystem.BLL.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/v{version:apiVersion}/Hotels")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepo;

        public HotelsController(IHotelRepository hotelRepo)
        {
            _hotelRepo = hotelRepo;
        }

        [HttpGet("GetHotels")]
        public IActionResult GetAllHotels()
        {
            return Ok(_hotelRepo.GetHotels());
        }
    }
}
