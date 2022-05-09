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
    public class RoomController : Controller
    {
        private readonly IRoomRepository _room;

        public RoomController(IRoomRepository branch)
        {
            _room = branch;
        }

        public async Task<IActionResult> Index(int id)
        {
            var rooms = await _room.GetById(id,SD.RoomAPIPath + "GetRoomByBranchId/", HttpContext.Session.GetString("JWToken"));
            return View(rooms);
        }
        public async Task<IActionResult> ShowDetails(int id)
        {

            var bookRoom = new BookRoom()
            {
                RoomData = await _room.GetByRoomId(id, SD.RoomAPIPath + "GetByRoomId/", HttpContext.Session.GetString("JWToken")),
                UserRoomsData = new UserRooms()
            };

            return View(bookRoom);
        }
    }
}
