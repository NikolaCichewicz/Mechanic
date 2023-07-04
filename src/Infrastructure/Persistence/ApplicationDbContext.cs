using System.Reflection;
using Duende.IdentityServer.EntityFramework.Options;
using Mechanic.Application.Common.Interfaces;
using Mechanic.Domain.Entities.Cars;
using Mechanic.Domain.Entities.Orders;
using Mechanic.Domain.Entities.Users;
using Mechanic.Infrastructure.Persistence.Interceptors;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Mechanic.Infrastructure.Persistence;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
{
    private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;
    private readonly IMediator _mediator;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IOptions<OperationalStoreOptions> operationalStoreOptions,
        IMediator mediator,
        AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
        : base(options, operationalStoreOptions)
    {
        _mediator = mediator;
        _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
    }

    public DbSet<Car> Cars => Set<Car>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<Pricing> Pricing => Set<Pricing>();

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
        
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "User");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "User");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "User");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "User");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
    }
}