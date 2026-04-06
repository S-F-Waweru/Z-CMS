using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class LoanApprovalConfiguration : IEntityTypeConfiguration<LoanApproval>
{
    public void Configure(EntityTypeBuilder<LoanApproval> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.MemberLoanId).IsUnique(); // one approval per loan
        builder.HasOne(x => x.Meeting)
            .WithMany(x => x.LoanApprovals)
            .HasForeignKey(x => x.MeetingId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.MemberLoan)
            .WithOne(x => x.LoanApproval)
            .HasForeignKey<LoanApproval>(x => x.MemberLoanId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
