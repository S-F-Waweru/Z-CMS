using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class MeetingConfiguration : IEntityTypeConfiguration<Meeting>
{
    public void Configure(EntityTypeBuilder<Meeting> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Venue).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Agenda).IsRequired();
        builder.Property(x => x.Minutes).HasColumnType("text");
    }
}
