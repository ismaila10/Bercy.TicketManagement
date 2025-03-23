using Bercy.TicketManagement.Domain.Entities;

namespace Bercy.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
    }
}
