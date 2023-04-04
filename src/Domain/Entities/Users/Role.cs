using Microsoft.AspNetCore.Identity;

namespace Mechanic.Domain.Entities.Users;

public class Role : IdentityRole
{
    public ICollection<ApplicationUser>? Users { get; set; }
    
    public ICollection<UserRole> UserRoles { get; set; } = null!;
}