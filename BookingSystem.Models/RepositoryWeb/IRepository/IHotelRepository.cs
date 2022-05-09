using BookingSystem.BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingApp.DataAccess.RepositoryWeb.IRepository
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> GetAllHotels(string url, string token = "");
    }
}
