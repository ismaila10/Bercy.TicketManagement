using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bercy.TicketManagement.Api.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
