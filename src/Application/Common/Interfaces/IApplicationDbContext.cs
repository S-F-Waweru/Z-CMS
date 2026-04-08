using Zeira.Domain.Entities;

namespace Zeira.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    /// <summary>
/// Persists all tracked changes to the underlying data store.
/// </summary>
/// <param name="cancellationToken">Cancellation token to observe while performing the save operation.</param>
/// <returns>The number of state entries written to the underlying data store.</returns>
    DbSet<Member> Members { get; }
    DbSet<ChamaSettings> ChamaSettings { get; }
    DbSet<Contribution> Contributions { get; }
    DbSet<MemberLoan> MemberLoans { get; }
    DbSet<MemberLoanRepayment> MemberLoanRepayments { get; }
    DbSet<ChamaLoan> ChamaLoans { get; }
    DbSet<ChamaLoanRepayment> ChamaLoanRepayments { get; }
    DbSet<ChamaLoanMemberSplit> ChamaLoanMemberSplits { get; }
    DbSet<Investment> Investments { get; }
    DbSet<Meeting> Meetings { get; }
    DbSet<MeetingAttendee> MeetingAttendees { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
