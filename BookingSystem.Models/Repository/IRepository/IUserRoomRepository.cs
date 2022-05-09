using BookingSystem.DAL.Entity;
using System.Collections.Generic;

namespace BookingSystem.BLL.Repository.IRepository
{
    public interface IUserRoomRepository
    {
        bool AddUserToRoom(UserRooms entity);
        IEnumerable<UserRooms> UserRoom(string UserId);
        void CancelBook(int id);

    }
}