using BookingSystem.BLL.ViewModels;
using System.Threading.Tasks;

namespace BookingApp.DataAccess.RepositoryWeb.IRepository
{
    public interface IUserRepository
    {
        Task<User> LoginAsync(string url, User objToCreate);
        Task<bool> RegisterAsync(string url, User objToCreate);
    }
}
