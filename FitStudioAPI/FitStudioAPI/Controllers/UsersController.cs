using AutoMapper;
using FitStudioAPI.JwtFeatures;
using FitStudioAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;

namespace FitStudioAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly FitStudioContext _fitStudioContext;
        private readonly IMapper _mapper;
        private readonly JwtHandler _jwtHandler;
        public UsersController(UserManager<User> userManager, FitStudioContext fitStudioContext, IMapper mapper, JwtHandler jwtHandler)
        {
            _userManager = userManager;
            _fitStudioContext = fitStudioContext;
            _mapper = mapper;
            _jwtHandler = jwtHandler;
        }

        [HttpGet("usersList")]
        public async Task<List<User>> GetUsersList()
        {
            return await _userManager.Users.ToListAsync();
        }


        //[HttpGet("user/{id}")]
        //public async Task<ActionResult<User>> GetUserById(string id)
        //{
        //    var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
        //    if (user == null) { return NotFound(); }
        //    return Ok(user);
        //}


        [HttpGet("user")]
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId

             // to get current user info
              var user = await _userManager.FindByIdAsync(userId);

            // to give the user's userName
            var userName = User.FindFirstValue(ClaimTypes.Name);
            return Ok(new { userId, userName });


    }

    }
}
