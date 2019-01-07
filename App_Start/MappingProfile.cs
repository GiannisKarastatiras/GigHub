using AutoMapper;
using GigHub_BC5.Dtos;
using GigHub_BC5.Models;

namespace GigHub_BC5.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ApplicationUser, UserDto>();
                cfg.CreateMap<Gig, GigDto>();
                cfg.CreateMap<Notification, NotificationDto>();
            });
            IMapper mapper = config.CreateMapper();
        }
    }
}