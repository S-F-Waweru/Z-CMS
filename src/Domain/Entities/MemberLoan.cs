namespace Zeira.Domain.Entities;

public class MemberLoan : BaseAuditableEntity
{
  public int MemberLoanId {get; set;}
  public decimal Amount { get; set; }
  public decimal InterestRate { get; set; }
  public DateOnly? IssueDate { get; set; }
  public DateOnly? DueDate { get; set; }
  public LoanStatus Status { get; set; } = LoanStatus.Pending;
  public int? ApprovalMeetingId { get; set; }
  
  // Snapshot of eligibility at time of application (stored as JSON)
  public string EligibilitySnapshot { get; set; } = string.Empty;
  
  // Navigation
  public Member Member { get; set; } = null!;
  public Meeting? ApprovalMeeting { get; set; }
  public ICollection<MemberLoanRepayment> Repayments { get; set; } = [];
  public LoanApproval? LoanApproval { get; set; }

}
