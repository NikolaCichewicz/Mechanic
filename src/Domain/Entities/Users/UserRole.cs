using Microsoft.AspNetCore.Identity;

namespace Mechanic.Domain.Entities.Users;

public class UserRole : IdentityUserRole<string>
{
    public override string UserId { get; set; } = null!;
    
    public ApplicationUser User { get; set; } = null!;
    
    public override string RoleId { get; set; } = null!;
    
    public Role Role { get; set; } = null!;
}