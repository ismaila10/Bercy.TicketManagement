using Bercy.TicketManagement.Domain.Entities;

namespace Bercy.TicketManagement.Application.Contracts.Persistence
{
    internal interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
