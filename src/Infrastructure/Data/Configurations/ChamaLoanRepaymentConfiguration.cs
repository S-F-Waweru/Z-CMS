using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class ChamaLoanRepaymentConfiguration :IEntityTypeConfiguration<ChamaLoanRepayment>
{
    public void Configure(EntityTypeBuilder<ChamaLoanRepayment> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Amount).HasPrecision(18, 2).IsRequired();
        builder.HasOne(x => x.ChamaLoan)
            .WithMany(x => x.Repayments)
            .HasForeignKey(x => x.ChamaLoanId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
