namespace Zeira.Domain.Entities;

// Singleton — only one row exists in the table
public class ChamaSettings  : BaseAuditableEntity
{
 public int MinContributionMonths {get; set;} = 3;
 public decimal LoanMultiplier {get; set;} = 3;
 public decimal DefaultMemberInterestRate {get; set;} = 10;// percentage
 public decimal DefaultChamaLoanInterestRate {get; set;} = 12;
 public ContributionCycleType CycleType {get; set;} = ContributionCycleType.Monthly;
 public decimal ContributionAmount {get; set;}
}
