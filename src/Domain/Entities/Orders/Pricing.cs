using Mechanic.Domain.Enums.Orders;

namespace Mechanic.Domain.Entities.Orders;

public class Pricing : BaseAuditableEntity, IBaseEntity
{
    public Guid Id { get; set; }
    
    public PricingType Type { get; set; }

    public string Name { get; set; } = null!;
    
    public int Quantity { get; set; }
    
    public decimal NetValue { get; set; }
    
    public int Tax { get; set; }
    
    public decimal GrossValue { get; set; }
    
    
    public Guid OrderId { get; set; }
    
    public Order Order { get; set; } = null!;
}