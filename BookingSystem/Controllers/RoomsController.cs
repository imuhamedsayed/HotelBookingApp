using BookingSystem.BLL.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/v{version:apiVersion}/Rooms")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomRepository _roomRepo;

        public RoomsController(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        [HttpGet("GetRooms")]
        public IActionResult GetRooms()
        {
            var model = _roomRepo.Get();
            return Ok(model);
        }
        
        [HttpGet("GetRoomByBranchId/{roomId:int}")]
        public IActionResult GetRoom(int roomId)
        {
            var model = _roomRepo.GetById(roomId);
            return Ok(model);
        }
        [HttpGet("GetByRoomId/{roomId:int}")]
        public IActionResult GetByRoomId(int roomId)
        {
            var model = _roomRepo.GetByRoomId(roomId);
            return Ok(model);
        }

    }
}