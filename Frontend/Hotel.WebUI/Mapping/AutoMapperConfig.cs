using AutoMapper;
using Hotel.EntityLayer.Concrete;
using Hotel.WebUI.Dtos.LoginDto;
using Hotel.WebUI.Dtos.RegisterDto;
using Hotel.WebUI.Dtos.ServiceDto;

namespace Hotel.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ServiceResultDto,Service>().ReverseMap();            
            CreateMap<ServiceUpdateDto,Service>().ReverseMap();            
            CreateMap<ServiceCreateDto,Service>().ReverseMap();

            CreateMap<NewUserCreateDto,AppUser>().ReverseMap();
            CreateMap<UserLoginDto,AppUser>().ReverseMap();
        }
    }
}
