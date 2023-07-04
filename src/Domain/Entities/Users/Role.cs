using Microsoft.AspNetCore.Identity;

namespace Mechanic.Domain.Entities.Users;

public class Role : IdentityRole
{
    public Role(string roleName) : base(roleName) { }
    public Role() {}
    public ICollection<ApplicationUser>? Users { get; set; } = null!;

    public ICollection<UserRole> UserRoles { get; set; } = null!;
}