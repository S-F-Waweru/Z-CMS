using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class ChamaLoanConfiguration : IEntityTypeConfiguration<ChamaLoan>
{
    public void Configure(EntityTypeBuilder<ChamaLoan> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.LenderName).IsRequired().HasMaxLength(150);
        builder.Property(x => x.Amount).HasPrecision(18, 2).IsRequired();
        builder.Property(x => x.InterestRate).HasPrecision(5, 2).IsRequired();
        builder.HasOne(x => x.LinkedInvestment)
            .WithOne(x => x.FundedByChamaLoan)
            .HasForeignKey<ChamaLoan>(x => x.LinkedInvestmentId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
