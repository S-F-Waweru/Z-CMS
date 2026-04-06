using System.Reflection;
using Zeira.Application.Common.Interfaces;
using Zeira.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public DbSet<Member> Members => Set<Member>();
    public DbSet<ChamaSettings> ChamaSettings => Set<ChamaSettings>();
    public DbSet<Contribution> Contributions => Set<Contribution>();
    public DbSet<MemberLoan> MemberLoans => Set<MemberLoan>();
    public DbSet<MemberLoanRepayment> MemberLoanRepayments => Set<MemberLoanRepayment>();
    public DbSet<ChamaLoan> ChamaLoans => Set<ChamaLoan>();
    public DbSet<ChamaLoanRepayment> ChamaLoanRepayments => Set<ChamaLoanRepayment>();
    public DbSet<ChamaLoanMemberSplit> ChamaLoanMemberSplits => Set<ChamaLoanMemberSplit>();
    public DbSet<Investment> Investments => Set<Investment>();
    public DbSet<Meeting> Meetings => Set<Meeting>();
    public DbSet<MeetingAttendee> MeetingAttendees => Set<MeetingAttendee>();
    // public DbSet<LoanApproval> LoanApprovals => Set<LoanApproval>();
    /// <summary>
    /// Initializes a new ApplicationDbContext with the provided DbContext options.
    /// </summary>
    /// <param name="options">The options that configure the database context (provider, connection string, and related behavior).</param>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
        
    }
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
