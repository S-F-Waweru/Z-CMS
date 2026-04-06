using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class MemberLoanRepaymentConfiguration : IEntityTypeConfiguration<MemberLoanRepayment>
{
    public void Configure(EntityTypeBuilder<MemberLoanRepayment> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Amount).HasPrecision(18, 2).IsRequired();
        builder.HasOne(x => x.MemberLoan)
            .WithMany(x => x.Repayments)
            .HasForeignKey(x => x.MemberLoanId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
