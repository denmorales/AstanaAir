using AstanaAir.Application.Common.Dto;
using AstanaAir.Domain.Entities;

namespace DataAccess.Mapping;

public class Profile : AutoMapper.Profile
{
    public Profile()
    {
        CreateMap<Flight, GetAllFlightsDto>()
            .ForMember(dest => dest.Arrival, options => options.MapFrom(i => i.Arrival))
            .ForMember(dest => dest.Departure, options => options.MapFrom(i => i.Departure))
            .ForMember(dest => dest.Destination, options => options.MapFrom(i => i.Destination))
            .ForMember(dest => dest.Status, options => options.MapFrom(i => i.Status))
            .ForMember(dest => dest.Origin, options => options.MapFrom(i => i.Origin));
    }
}