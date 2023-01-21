using AutoMapper;
using FitStudio_App.Context;


using FitStudio_App.Models;
using FitStudio_App.Models.DTOs.Auth;
using FitStudio_App.Services.Interface;
using FitStudioAPI.Models.DTOs.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FitStudio_App.Controllers
{
    public class AuthController : BaseApiController
    {

        private readonly IMapper _mapper;
        private readonly AppDbContext _context;
        private readonly IPasswordHash _passwordHash;
        private readonly IGenerateToken _token;


        public AuthController(IMapper mapper, AppDbContext context, IPasswordHash passwordHash, IGenerateToken token)
        {
            _mapper = mapper;
            _context = context;
            _passwordHash = passwordHash;
            _token = token;

        }





        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterUserDTO registerUser)
        {
            var mappedUser = _mapper.Map<User>(registerUser);
            var userExists = await _context.Users.FirstOrDefaultAsync(u => u.Email == registerUser.Email);
            if (userExists == null)
            {
                _passwordHash.HashPassword(registerUser.Password, out byte[] passwordHash, out byte[] passwordSalt);
                mappedUser.FirstName = registerUser.FirstName;
                mappedUser.LastName = registerUser.LastName;
                mappedUser.Email = registerUser.Email;
                mappedUser.PaswordHash = passwordHash;
                mappedUser.PaswordSalt = passwordSalt;
                mappedUser.CreatedAt = DateTime.UtcNow;
                mappedUser.RoleId = 2;
                mappedUser.TokenExpires = DateTime.UtcNow.AddMinutes(30);


                _context.Users.Add(mappedUser);

                await _context.SaveChangesAsync();
                return Ok(new RegistrationResponseDTO { IsSuccessfulRegistration = true });
            }
            else
            {
                return BadRequest(new RegistrationResponseDTO { ErrorMessage = "User already exists" });

            }
        }


        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginUserDTO loginUser)
        {
            var userExists = await _context.Users.FirstOrDefaultAsync(u => u.Email == loginUser.Email);
            if (userExists == null)
            {
                return BadRequest("User not found");
            }
            else if (!_passwordHash.VerifyPassword(loginUser.Password, userExists.PaswordHash, userExists.PaswordSalt))
            {
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authentication" });
            }

            var accessToken = _token.GenerateAccessToken(userExists);
            var refreshToken = _token.GenerateRefreshToken();

            userExists.Token = accessToken;
            userExists.RefreshToken = refreshToken.Token;
            userExists.CreatedAt = refreshToken.CreatedAt;
            userExists.TokenExpires = refreshToken.Expires;

            await _context.SaveChangesAsync();
           
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = accessToken }) ;

        }

    }
}
