using Bercy.TicketManagement.Application.Responses;

namespace Bercy.TicketManagement.Application.Features.Categories.Commands
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base()
        {

        }

        public CreateCategoryDto Category { get; set; } = default!;

    }
}
