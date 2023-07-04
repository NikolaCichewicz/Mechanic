using Mechanic.Domain.Entities.Cars;
using Mechanic.Domain.Entities.Orders;
using Microsoft.AspNetCore.Identity;

namespace Mechanic.Domain.Entities.Users;

public class ApplicationUser : IdentityUser, IBaseAuditableEntity
{
    public UserStatus Status { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;


    public virtual ICollection<UserRole> UserRoles { get; set; } = null!;

    public IList<Order> Orders { get; set; } = null!;

    public IList<Car> Cars { get; set; } = null!;

    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}