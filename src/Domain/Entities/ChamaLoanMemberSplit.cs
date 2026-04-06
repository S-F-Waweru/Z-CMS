namespace Zeira.Domain.Entities;

// Used when ChamaLoanRepayment.RepaymentType = SplitAcrossMembers
public class ChamaLoanMemberSplit : BaseAuditableEntity
{
    public int ChamaLoanRepaymentId { get; set; }
    public int MemberId { get; set; }
    public decimal Amount { get; set; }

    // Navigation
    public ChamaLoanRepayment ChamaLoanRepayment { get; set; } = null!;
    public Member Member { get; set; } = null!;
}
