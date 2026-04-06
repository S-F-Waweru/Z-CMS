using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class InvestmentConfiguration :IEntityTypeConfiguration<Investment>
{
    public void Configure(EntityTypeBuilder<Investment> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
        builder.Property(x => x.AmountInvested).HasPrecision(18, 2).IsRequired();
        builder.Property(x => x.ExpectedReturn).HasPrecision(18, 2);
        builder.Property(x => x.ActualReturn).HasPrecision(18, 2);
    }
}
