using Mechanic.Application.Common.Interfaces;

namespace Mechanic.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
