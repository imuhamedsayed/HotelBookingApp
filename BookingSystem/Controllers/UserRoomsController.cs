using BookingSystem.BLL.Repository.IRepository;
using BookingSystem.DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/v{version:apiVersion}/UserRooms")]
    [ApiController]
    public class UserRoomsController : ControllerBase
    {
        private readonly IUserRoomRepository _userRoomRepo;

        public UserRoomsController(IUserRoomRepository userRoomRepo)
        {
            _userRoomRepo = userRoomRepo;
        }

        [HttpGet("GetUserRooms/{userId}")]
        public IActionResult GetUserRooms(string userId)
        {
            var model = _userRoomRepo.UserRoom(userId);
            return Ok(model);
        }
        
        [HttpPost("AddUserRoom")]
        public IActionResult AddUserRoom(UserRooms entity)
        {
            var model = _userRoomRepo.AddUserToRoom(entity);
            return Ok();
        }

        [HttpPost("CancelRoom/{id:int}")]
        public IActionResult CancelRooms(int id)
        {
            _userRoomRepo.CancelBook(id);
            return Ok();
        }
    }
}