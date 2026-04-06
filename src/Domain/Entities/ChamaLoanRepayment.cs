using Zeira.Domain.Enums;

namespace Zeira.Domain.Entities;

public class ChamaLoanRepayment : BaseAuditableEntity
{
    public int ChamaLoanId { get; set; }
    public decimal Amount { get; set; }
    public DateOnly Date { get; set; }
    public RepaymentType RepaymentType { get; set; }
    public string? Notes { get; set; }

    // Navigation
    public ChamaLoan ChamaLoan { get; set; } = null!;
    public ICollection<ChamaLoanMemberSplit> MemberSplits { get; set; } = [];
}
