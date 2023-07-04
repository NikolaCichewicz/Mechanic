using Mechanic.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mechanic.Infrastructure.Persistence.Configurations.Users;

public class UserRoleConfig : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UserRoles", "User");
        
        builder.HasKey(t => new { t.UserId, t.RoleId });
        
        builder.HasOne(x => x.Role)
            .WithMany(y => y.UserRoles)
            .HasForeignKey(xy => xy.RoleId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.User)
            .WithMany(y => y.UserRoles)
            .HasForeignKey(xy => xy.UserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}