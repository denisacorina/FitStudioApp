using AutoMapper;
using FitStudioAPI.Models;

namespace FitStudioAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterUserDTO, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
                .ReverseMap();
            CreateMap<AuthenticationDTO, User>().ReverseMap();
        }

    }
}
