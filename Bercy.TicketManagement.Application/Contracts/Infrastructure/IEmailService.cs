using Bercy.TicketManagement.Application.Models.Mail;

namespace Bercy.TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(Email email);
    }
}
