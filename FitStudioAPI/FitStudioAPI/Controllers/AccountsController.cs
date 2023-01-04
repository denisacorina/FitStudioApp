using AutoMapper;
using FitStudioAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        public AccountsController(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO registerUser)
        {
            try
            {
                if (registerUser == null || !ModelState.IsValid) return BadRequest();

                registerUser.CreatedAt = DateTime.UtcNow;

                var mappedUser = _mapper.Map<User>(registerUser);
                var user = await _userManager.CreateAsync(mappedUser, registerUser.Password);

                
                if (!user.Succeeded)
                {
                    var errors = user.Errors.Select(e => e.Description);
                    return BadRequest(new RegistrationResponseDTO { Errors = errors });
                }

                return StatusCode(201);
            }
            catch (Exception ex)
            { 
                return BadRequest(ex);
            }
        }

        }
}
