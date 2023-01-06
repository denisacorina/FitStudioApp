using AutoMapper;
using FitStudioAPI.JwtFeatures;
using FitStudioAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace FitStudioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly JwtHandler _jwtHandler;
        public AccountsController(UserManager<User> userManager, IMapper mapper, JwtHandler jwtHandler)
        {
            _userManager = userManager;
            _mapper = mapper;
            _jwtHandler = jwtHandler;
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

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] AuthenticationDTO authentication)
        {
            var user = await _userManager.FindByNameAsync(authentication.Email);

            if (user == null || !await _userManager.CheckPasswordAsync(user, authentication.Password))
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication"});

            var signingCredentials = _jwtHandler.GetSigningCredentials();
            var claims = _jwtHandler.GetClaims(user);
            var tokenOptions = _jwtHandler.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }

    }
}
