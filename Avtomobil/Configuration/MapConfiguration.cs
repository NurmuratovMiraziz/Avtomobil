using AutoMapper;
using Avtomobil.DTO;
using Avtomobil.DTO.Identity;
using CorrectMistakes.Data.Model;
using CorrectMistakes.Data.Model.Identity;

namespace Avtomobil.Configuration
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration() 
        {
            CreateMap<CarAddDTO, Car>().ReverseMap();

            CreateMap<ApiUser, UserDto>().ReverseMap();

            CreateMap<AddAutosalonDTO, Autosalon>().ReverseMap();
        }
    }
}
