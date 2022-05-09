using BookingSystem.BLL.Repository.IRepository;
using BookingSystem.DAL;
using BookingSystem.DAL.DatabaseContext;
using BookingSystem.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookingSystem.BLL.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly AppSettings _appSettings;

        public BranchRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Branch> Get()
        {
            //var data = _db.Branches.Select(e => e).Include(a => a.Hotel).Include(a => a.Rooms);
            //var data = _db.Branches.Include(a => a.Hotel).Include(a => a.Rooms).ToList();
            var data = _db.Branches.ToList();
            return data;
        }

        public Branch GetById(int id)
        {
            var data = _db.Branches.Include(a => a.Hotel).Include(a => a.Rooms).Where(e => e.Id == id).FirstOrDefault();
            return data;
        }
    }
}