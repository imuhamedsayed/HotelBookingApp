using BookingSystem.BLL.Repository.IRepository;
using BookingSystem.DAL.DatabaseContext;
using BookingSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.BLL.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _db;

        public RoomRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Room> Get()
        {
            var data = _db.Room.Include(a => a.Branch).Include(a => a.UserRooms); ;
            return data;
        }

        public IEnumerable<Room> GetById(int id)
        {
            var data = _db.Room.Include(a => a.Type).Include(a => a.Branch).Include(a => a.UserRooms).Where(e => e.BranchId == id).ToList(); 
            return data;
        }

        public Room GetByRoomId(int id)
        {
            var data = _db.Room.Include(a => a.Type).Include(a => a.UserRooms).Include(a => a.Branch).ThenInclude(a => a.Hotel).Where(e => e.Id == id).FirstOrDefault();
            return data;
        }
    }
}
