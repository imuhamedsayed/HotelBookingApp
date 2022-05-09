using BookingApp.DataAccess.RepositoryWeb.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookingApp.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HotelController : Controller
    {
        private readonly IHotelRepository _hotelRepo;

        public HotelController(IHotelRepository hotelRepo)
        {
            _hotelRepo = hotelRepo;
        }

        public async Task<IActionResult> Index()
        {
            var hotels = await _hotelRepo.GetAllHotels(SD.HotelAPIPath + "GetAllHotels", HttpContext.Session.GetString("JWToken"));
            return View(hotels);
        }
    }
}