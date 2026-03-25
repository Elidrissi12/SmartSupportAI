using Microsoft.EntityFrameworkCore;
using SmartSupportAI.Domain.Entities;

namespace SmartSupportAI.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Ticket> Tickets => Set<Ticket>();
}
