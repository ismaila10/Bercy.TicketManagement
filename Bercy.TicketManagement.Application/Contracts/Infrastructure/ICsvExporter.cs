using Bercy.TicketManagement.Application.Features.Events.Queries.GetEventsExport;

namespace Bercy.TicketManagement.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
