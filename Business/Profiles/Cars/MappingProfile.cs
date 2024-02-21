using AutoMapper;
using Business.Requests.Car;
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
