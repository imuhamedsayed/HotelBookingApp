using BookingSystem.BLL.RepositoryWeb.IRepository;
using BookingSystem.BLL.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Web.Controllers
{
    public class UserRoomController : Controller
    {
        private readonly IUserRoomRepository _userroom;

        public UserRoomController(IUserRoomRepository userroom)
        {
            _userroom = userroom;
        }

        public async Task<IActionResult> Index()
        {
            var userroom = await _userroom.UserRoom(HttpContext.Session.GetString("UserName"), SD.UserRoomAPIPath + "GetUserRooms/", HttpContext.Session.GetString("JWToken"));
            return View(userroom);
        }

        
        public async Task<IActionResult> Booking(BookRoom model)
        {
            model.UserRoomsData.TotalPrice = model.UserRoomsData.NightNo * model.RoomData.Type.PricePerNight;
            model.UserRoomsData.UserName = HttpContext.Session.GetString("UserName");
            model.UserRoomsData.RoomId = model.RoomData.Id;
            var userroom = await _userroom.AddUserToRoom(model.UserRoomsData, SD.UserRoomAPIPath + "AddUserRoom", HttpContext.Session.GetString("JWToken"));
            return RedirectToAction("Booked");
        }

        public IActionResult Booked()
        {
            return View();
        }

        public async Task<IActionResult> CancelBooking(int id)
        {
            var rooms = await _userroom.CancelBook(id, SD.UserRoomAPIPath + "CancelRoom/", HttpContext.Session.GetString("JWToken"));
            return RedirectToAction("Deleted");
        }
        public IActionResult Deleted()
        {
            return View();
        }
    }
 
}
