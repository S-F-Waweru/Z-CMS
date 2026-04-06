namespace Zeira.Domain.Entities;

public class MemberLoanRepayment : BaseAuditableEntity
{
    public int MemberLoanId { get; set; }
    public decimal Amount { get; set; }
    public DateOnly Date { get; set; }
    public string? Notes { get; set; }

    // Navigation
    public MemberLoan MemberLoan { get; set; } = null!;
}
