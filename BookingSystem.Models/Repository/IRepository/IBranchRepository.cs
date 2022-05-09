using BookingSystem.DAL.Entity;
using System.Collections.Generic;

namespace BookingSystem.BLL.Repository.IRepository
{
    public interface IBranchRepository
    {
        IEnumerable<Branch> Get();
        Branch GetById(int id);
    
    }
}
