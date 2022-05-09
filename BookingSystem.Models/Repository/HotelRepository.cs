using BookingSystem.BLL.Repository.IRepository;
using BookingSystem.DAL.DatabaseContext;
using BookingSystem.DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BookingSystem.BLL.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly ApplicationDbContext _db;

        public HotelRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Hotel> GetHotels()
        {
            return _db.Hotels.ToList();
        }
    }
}