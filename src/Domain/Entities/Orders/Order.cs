using Mechanic.Domain.Entities.Cars;
using Mechanic.Domain.Entities.Users;
using Mechanic.Domain.Enums.Orders;

namespace Mechanic.Domain.Entities.Orders;

public class Order : BaseAuditableEntity, IBaseEntity
{
    public Guid Id { get; set; }

    public OrderStatus Status { get; set; }
    
    public PriorityLevel PriorityLevel { get; set; }
    

    public string UserId { get; set; } = null!;
    
    public ApplicationUser User { get; set; } = null!;
    
    public Guid CarId { get; set; }
    
    public Car Car { get; set; } = null!;
    
    public IList<Pricing> Pricing { get; set; } = new List<Pricing>();
}