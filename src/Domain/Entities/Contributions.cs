namespace Zeira.Domain.Entities;

public class Contributions : BaseAuditableEntity
{
    public int MemberId {get; set;}
    public decimal Amount {get; set;}
    public DateTime Date {get; set;}
    public string CycleReference {get; set;} = string.Empty;// e.g. "2025-01"
    public  string? Notes { get; set; }
    
    // Navigation
    public Member Member {get; set;} = null!;
}
