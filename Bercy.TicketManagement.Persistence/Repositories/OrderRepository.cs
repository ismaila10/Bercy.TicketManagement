using Bercy.TicketManagement.Application.Contracts.Persistence;
using Bercy.TicketManagement.Domain.Entities;

namespace Bercy.TicketManagement.Persistence.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(BercyTicketDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
