﻿namespace Bercy.TicketManagement.Application.Features.Events.Queries.GetEventList
{
    public class EventListVm
    {
        public Guid EventId { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public string? ImageUrl { get; set; }
    }
}
