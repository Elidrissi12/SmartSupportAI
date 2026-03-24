using SmartSupportAI.Domain.Enums;

namespace SmartSupportAI.Application.DTOs.Tickets;

public class UpdateTicketDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TicketStatus Status { get; set; }
    public TicketPriority Priority { get; set; }
}