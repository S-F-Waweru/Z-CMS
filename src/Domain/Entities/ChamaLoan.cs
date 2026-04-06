using Zeira.Domain.Enums;

namespace Zeira.Domain.Entities;

public class ChamaLoan : BaseAuditableEntity
{
    public string LenderName { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public decimal InterestRate { get; set; }
    public DateOnly IssueDate { get; set; }
    public DateOnly DueDate { get; set; }
    public LoanStatus Status { get; set; } = LoanStatus.Active;
    public RepaymentType RepaymentType { get; set; }
    public int? LinkedInvestmentId { get; set; }

    // Navigation
    public Investment? LinkedInvestment { get; set; }
    public ICollection<ChamaLoanRepayment> Repayments { get; set; } = [];
}
