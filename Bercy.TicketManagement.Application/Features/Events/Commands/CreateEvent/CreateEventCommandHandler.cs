using AutoMapper;
using Bercy.TicketManagement.Application.Contracts.Infrastructure;
using Bercy.TicketManagement.Application.Contracts.Persistence;
using Bercy.TicketManagement.Application.Models.Mail;
using Bercy.TicketManagement.Domain.Entities;
using MediatR;

namespace Bercy.TicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand,
        Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public CreateEventCommandHandler(IEventRepository eventRepository, IEmailService emailService, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _emailService = emailService;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper.Map<Event>(request);

            var validator = new CreateEventCommandValidator(_eventRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            @event = await _eventRepository.AddAsync(@event);

            //Sending email notification to admin address
            var email = new Email() { To = "iso.lodia@gmail.com", 
                Body = $"A new enent wase created: {request}", 
                Subject = "A  new event was created" 
            };

            try
            {
                await _emailService.SendEmailAsync(email);
            }
            catch (Exception ex)
            {
                // This shouldn't stop the API from doing else so this can be logged
            }

            return @event.EventId;
        }
    }
}
