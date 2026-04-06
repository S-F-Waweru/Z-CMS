using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class ChamaSettingsConfiguration :IEntityTypeConfiguration<ChamaSettings>
{
    public void Configure(EntityTypeBuilder<ChamaSettings> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.LoanMultiplier).HasPrecision(5, 2);
        builder.Property(x => x.DefaultMemberInterestRate).HasPrecision(5, 2);
        builder.Property(x => x.DefaultChamaLoanInterestRate).HasPrecision(5, 2);
        builder.Property(x => x.ContributionAmount).HasPrecision(18, 2);
// Enforce singleton at app level — only ever seed one row
    }
}
