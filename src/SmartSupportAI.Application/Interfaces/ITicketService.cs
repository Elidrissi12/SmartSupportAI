using SmartSupportAI.Application.DTOs.Tickets;

namespace SmartSupportAI.Application.Interfaces;

public interface ITicketService
{
    Task<TicketDto> CreateAsync(CreateTicketDto dto, Guid userId, Guid tenantId);
    Task<List<TicketDto>> GetAllAsync(Guid tenantId);
    Task<TicketDto?> GetByIdAsync(Guid id, Guid tenantId);
    Task UpdateAsync(Guid id, UpdateTicketDto dto, Guid tenantId);
    Task DeleteAsync(Guid id, Guid tenantId);
}