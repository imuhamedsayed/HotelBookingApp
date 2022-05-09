using BookingSystem.BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingSystem.BLL.RepositoryWeb.IRepository
{
    public interface IBranchRepository
    {
        Task<IEnumerable<Branch>> Get(string url, string token = "");
        Task<Branch> GetById(int id, string url, string token = "");
    }
}
