using AutoMapper;
using FitStudio_App.Models;
using FitStudio_App.Models.DTOs.Auth;

namespace FitStudio_App.Helpers
{
    public class AutoMapper : Profile
    {
        public AutoMapper() {
            CreateMap<User, LoginUserDTO>().ReverseMap();        
            CreateMap<User, RegisterUserDTO>().ReverseMap();        
      
        }
    }
}
