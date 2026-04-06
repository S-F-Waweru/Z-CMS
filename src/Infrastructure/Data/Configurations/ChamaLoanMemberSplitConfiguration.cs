using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class ChamaLoanMemberSplitConfiguration :IEntityTypeConfiguration<ChamaLoanMemberSplit>
{
    public void Configure(EntityTypeBuilder<ChamaLoanMemberSplit> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Amount).HasPrecision(18, 2).IsRequired();
        builder.HasOne(x => x.ChamaLoanRepayment)
            .WithMany(x => x.MemberSplits)
            .HasForeignKey(x => x.ChamaLoanRepaymentId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.Member)
            .WithMany()
            .HasForeignKey(x => x.MemberId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
