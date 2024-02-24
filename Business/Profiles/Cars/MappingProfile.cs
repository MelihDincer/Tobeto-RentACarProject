using AutoMapper;
using Business.Requests.Cars;
using Business.Responses.Car;
using Entities.Concretes;

namespace Business.Profiles.Cars
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, GetAllCarResponse>().ReverseMap();
            CreateMap<Car, CreateCarResponse>().ReverseMap();
            CreateMap<Car, CreateCarRequest>().ReverseMap();
        }
    }
}
