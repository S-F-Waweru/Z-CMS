using Zeira.Domain.Enums;

namespace Zeira.Domain.Entities;

public class LoanApproval : BaseAuditableEntity
{
    public int MeetingId { get; set; }
    public int MemberLoanId { get; set; }
    public LoanDecision Decision { get; set; }
    public int VotesFor { get; set; }
    public int VotesAgainst { get; set; }
    public string? Notes { get; set; }

    // Navigation
    public Meeting Meeting { get; set; } = null!;
    public MemberLoan MemberLoan { get; set; } = null!;
}
