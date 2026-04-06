using Zeira.Domain.Enums;

namespace Zeira.Domain.Entities;

public class Meeting : BaseAuditableEntity
{
    public DateTime Date { get; set; }
    public string Venue { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    public string? Minutes { get; set; }
    public MeetingStatus Status { get; set; } = MeetingStatus.Scheduled;

    // Navigation
    public ICollection<MeetingAttendee> Attendees { get; set; } = [];
    public ICollection<LoanApproval> LoanApprovals { get; set; } = [];
    public ICollection<MemberLoan> ApprovedLoans { get; set; } = [];
}

