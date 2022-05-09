using BookingSystem.BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingSystem.BLL.RepositoryWeb.IRepository
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> Get(string url, string token = "");
        Task<IEnumerable<Room>> GetById(int id, string url, string token = "");
        Task<Room> GetByRoomId(int id, string url, string token = "");
    }
}
