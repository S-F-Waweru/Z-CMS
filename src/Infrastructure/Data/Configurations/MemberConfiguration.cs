using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class MemberConfiguration :IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
        builder.Property(x => x.PhonNumber).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Role).IsRequired();
        builder.Property(x => x.Status).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();
    }
}
