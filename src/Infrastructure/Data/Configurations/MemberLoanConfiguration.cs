using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class MemberLoanConfiguration : IEntityTypeConfiguration<MemberLoan>
{
    public void Configure(EntityTypeBuilder<MemberLoan> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Amount).HasPrecision(18, 2).IsRequired();
        builder.Property(x => x.InterestRate).HasPrecision(5, 2).IsRequired();
        builder.Property(x => x.EligibilitySnapshot).IsRequired().HasColumnType("jsonb");
        builder.HasOne(x => x.Member)
            .WithMany(x => x.Loans)
            .HasForeignKey(x => x.MemberId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.ApprovalMeeting)
            .WithMany(x => x.ApprovedLoans)
            .HasForeignKey(x => x.ApprovalMeetingId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
