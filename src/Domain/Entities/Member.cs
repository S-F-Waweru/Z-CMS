namespace Zeira.Domain.Entities;

public class Member : BaseAuditableEntity
{
    public string FullName{get; set;} = String.Empty;
    public string Email{get; set;} =  String.Empty;
    public string PhonNumber{get; set;} = String.Empty;
    
    public  MemberRole Role {get; set;} = MemberRole.Member;
    public MemberStatus Status {get; set;} = MemberStatus.Active;
    
    public DateOnly JoinDate {get; set;} 
    
    // Navigation
        public ICollection<Contributions> Contributions {get; set;} =[];
        public ICollection<MemberLoan> Loans {get; set;} =[];
        public ICollection<MeetingAttendee> MeetingAttendances {get; set;} =[];

}   
