using BookingSystem.DAL.Entity;
using System.Collections.Generic;

namespace BookingSystem.BLL.Repository.IRepository
{
    public interface IHotelRepository
    {
        IEnumerable<Hotel> GetHotels();
    }
}
