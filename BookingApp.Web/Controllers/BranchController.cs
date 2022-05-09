using BookingSystem.BLL.RepositoryWeb.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchRepository _branch;

        public BranchController(IBranchRepository branch)
        {
            _branch = branch;
        }

        public async Task<IActionResult> Index()
        {
            var branches = await _branch.Get(SD.BranchAPIPath + "GetBranches", HttpContext.Session.GetString("JWToken"));
            return View(branches);
        }

       
    }
}
