using AutoMapper;
using Hotel.EntityLayer.Concrete;
using Hotel.WebUI.Dtos.AboutDto;
using Hotel.WebUI.Dtos.BookingDto;
using Hotel.WebUI.Dtos.LoginDto;
using Hotel.WebUI.Dtos.RegisterDto;
using Hotel.WebUI.Dtos.ServiceDto;
using Hotel.WebUI.Dtos.SubscribeDto;

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

            CreateMap<AboutResultDto, About>().ReverseMap();
            CreateMap<AboutUpdateDto, About>().ReverseMap();

            CreateMap<SubscribeCreateDto, Subscribe>().ReverseMap();

            CreateMap<BookingCreateDto, Booking>().ReverseMap();
            CreateMap<BookingUpdateDto, Booking>().ReverseMap();
            CreateMap<BookingApprovedDto, Booking>().ReverseMap();
        }
    }
}
