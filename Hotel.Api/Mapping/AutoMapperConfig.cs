using AutoMapper;
using Hotel.DtoLayer.Dtos.RoomDto;
using Hotel.EntityLayer.Concrete;

namespace Hotel.Api.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto,Room>().ReverseMap();
            CreateMap<RoomUpdateDto,Room>().ReverseMap();

        }
    }
}
