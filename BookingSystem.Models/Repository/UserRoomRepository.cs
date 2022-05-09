using BookingSystem.BLL.Repository.IRepository;
using BookingSystem.DAL.DatabaseContext;
using BookingSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookingSystem.BLL.Repository
{
    public class UserRoomRepository : IUserRoomRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRoomRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool AddUserToRoom(UserRooms entity)
        {
            var CheckDiscount = UserRoom(entity.UserName);

            if (CheckDiscount.Any())
            {
                entity.TotalPrice = entity.TotalPrice - entity.TotalPrice * 95 / 100;
            }

            _db.UserRooms.Add(entity);
            _db.SaveChanges();
            return true;
        }

        public void CancelBook(int id)
        {
       
            var OldData = _db.UserRooms.Find(id);
            _db.UserRooms.Remove(OldData);
            _db.SaveChanges();
        }

        public IEnumerable<UserRooms> UserRoom(string UserId)
        {
            var userRooms = _db.UserRooms.Include(ur => ur.Room)
                .ThenInclude(r => r.Type).Include(e => e.Room.Branch).Where(ur => ur.UserName == UserId).ToList() ;
            return userRooms;
        }

        
    }
}
