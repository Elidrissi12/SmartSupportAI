using Microsoft.EntityFrameworkCore;
using SmartSupportAI.Application.DTOs.Tickets;
using SmartSupportAI.Application.Interfaces;
using SmartSupportAI.Domain.Entities;
using SmartSupportAI.Infrastructure.Persistence;

namespace SmartSupportAI.Infrastructure.Services;

public class TicketService : ITicketService
{
    private readonly AppDbContext _context;

    public TicketService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TicketDto> CreateAsync(CreateTicketDto dto, Guid userId, Guid tenantId)
    {
        var ticket = new Ticket
        {
            Title = dto.Title,
            Description = dto.Description,
            CreatedById = userId,
            TenantId = tenantId
        };

        _context.Tickets.Add(ticket);
        await _context.SaveChangesAsync();

        return MapToDto(ticket);
    }

    public async Task<List<TicketDto>> GetAllAsync(Guid tenantId)
    {
        var tickets = await _context.Tickets
            .Where(t => t.TenantId == tenantId)
            .ToListAsync();

        return tickets.Select(MapToDto).ToList();
    }

    public async Task<TicketDto?> GetByIdAsync(Guid id, Guid tenantId)
    {
        var ticket = await _context.Tickets
            .FirstOrDefaultAsync(t => t.Id == id && t.TenantId == tenantId);

        return ticket == null ? null : MapToDto(ticket);
    }

    public async Task UpdateAsync(Guid id, UpdateTicketDto dto, Guid tenantId)
    {
        var ticket = await _context.Tickets
            .FirstOrDefaultAsync(t => t.Id == id && t.TenantId == tenantId);

        if (ticket == null)
            throw new Exception("Ticket not found");

        ticket.Title = dto.Title;
        ticket.Description = dto.Description;
        ticket.Status = dto.Status;
        ticket.Priority = dto.Priority;
        ticket.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id, Guid tenantId)
    {
        var ticket = await _context.Tickets
            .FirstOrDefaultAsync(t => t.Id == id && t.TenantId == tenantId);

        if (ticket == null)
            throw new Exception("Ticket not found");

        _context.Tickets.Remove(ticket);
        await _context.SaveChangesAsync();
    }

    private static TicketDto MapToDto(Ticket ticket)
    {
        return new TicketDto
        {
            Id = ticket.Id,
            Title = ticket.Title,
            Description = ticket.Description,
            Status = ticket.Status,
            Priority = ticket.Priority
        };
    }
}