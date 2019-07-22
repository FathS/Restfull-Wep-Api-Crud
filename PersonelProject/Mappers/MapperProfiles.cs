using AutoMapper;
using PersonelProject.DTO;
using static PersonelProject.Models.Data.PersonelEntities;

namespace PersonelProject.Mappers
{
    public class MapperProfiles:Profile
    {
        public MapperProfiles()
        {
            CreateMap<City, CityDTO>().ForMember(dest => dest.name, opt => opt
          .MapFrom(src => src.CityName)).
        ForMember(dest => dest.cityImage, opt => opt
          .MapFrom(src => src.Image)).ForMember(dest => dest.cityId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
