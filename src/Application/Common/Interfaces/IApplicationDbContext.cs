using Mechanic.Domain.Entities.Cars;
using Mechanic.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace Mechanic.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Car> Cars { get; }
    DbSet<Order> Orders { get; }
    DbSet<Pricing> Pricing { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}