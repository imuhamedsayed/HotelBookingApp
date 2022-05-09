using BookingSystem.DAL.Entity;
using System.Collections.Generic;

namespace BookingSystem.BLL.Repository.IRepository
{
    public interface IRoomRepository
    {
        IEnumerable<Room> Get();
        IEnumerable<Room> GetById(int id);
        Room GetByRoomId(int id);
    }
}
