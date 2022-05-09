using BookingSystem.BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingSystem.BLL.RepositoryWeb.IRepository
{
    public interface IUserRoomRepository
    {
        Task<bool> AddUserToRoom(UserRooms entity, string url, string token = "");
        Task<IEnumerable<UserRooms>> UserRoom(string id, string url, string token = "");
        Task<string> CancelBook(int id, string url, string token = "");

    }
}