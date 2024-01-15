using DAL.DTO;
using DAL.Entities;
using AutoMapper;
using DAL.ModelsDTO;

namespace CarBookingWebApi.MappingConfiguration
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<UserRegisterDTO, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
            CreateMap<BookCarDTO, CarBooking>();
            CreateMap<CarDTO, Car>();
        }

    }
}
