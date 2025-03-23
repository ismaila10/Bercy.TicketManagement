using AutoMapper;
using Bercy.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using Bercy.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using Bercy.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using Bercy.TicketManagement.Application.Features.Events.Queries.GetEventList;
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

            CreateMap<Category, CategoryListVm>().ReverseMap();

            CreateMap<Category, CategoryEventListVm>().ReverseMap();
        }
    }
}
