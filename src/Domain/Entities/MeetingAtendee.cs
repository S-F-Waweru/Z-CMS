namespace Zeira.Domain.Entities;

public class MeetingAttendee : BaseAuditableEntity
{
    public int MeetingId { get; set; }
    public int MemberId { get; set; }
    public bool Attended { get; set; }

    // Navigation
    public Meeting Meeting { get; set; } = null!;
    public Member Member { get; set; } = null!;
}
