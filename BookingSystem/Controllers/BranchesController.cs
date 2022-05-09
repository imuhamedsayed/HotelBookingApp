using BookingSystem.BLL.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/v{version:apiVersion}/Branches")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly IBranchRepository _branchRepo;

        public BranchesController(IBranchRepository branchRepo)
        {
            _branchRepo = branchRepo;
        }

        [HttpGet("GetBranches")]
        public IActionResult GetBranches()
        {
            var model = _branchRepo.Get();
            return Ok(model);
        }
        
        [HttpGet("GetBranch/{branchid:int}")]
        public IActionResult GetBranchById(int branchid)
        {
            var model = _branchRepo.GetById(branchid);
            return Ok(model);
        }
    }
}