using Zeira.Domain.Enums;

namespace Zeira.Domain.Entities;

public class Investment : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal AmountInvested { get; set; }
    public DateOnly InvestmentDate { get; set; }
    public decimal? ExpectedReturn { get; set; }
    public decimal? ActualReturn { get; set; }
    public InvestmentStatus Status { get; set; } = InvestmentStatus.Ongoing;
    public int? FundedByChamaLoanId { get; set; }

    // Navigation
    public ChamaLoan? FundedByChamaLoan { get; set; }
}
