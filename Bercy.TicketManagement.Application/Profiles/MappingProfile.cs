using AutoMapper;
using Bercy.TicketManagement.Application.Features.Events;
using Bercy.TicketManagement.Domain.Entities;

namespace Bercy.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Event, EventDetailVm>().ReverseMap();
        }
    }
}
