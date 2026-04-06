using System.Reflection;
using Zeira.Application.Common.Interfaces;
using Zeira.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Zeira.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    /// <summary>
/// Initializes a new ApplicationDbContext with the provided DbContext options.
/// </summary>
/// <param name="options">The options that configure the database context (provider, connection string, and related behavior).</param>
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    /// <summary>
    /// Configures the EF Core model for the context by invoking the base Identity model configuration and applying all entity configurations from the executing assembly.
    /// </summary>
    /// <param name="builder">The <see cref="ModelBuilder"/> used to configure entity mappings, keys, and relationships.</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
