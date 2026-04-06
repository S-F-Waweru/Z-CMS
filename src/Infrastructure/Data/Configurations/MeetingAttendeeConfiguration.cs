using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeira.Domain.Entities;

namespace Zeira.Infrastructure.Data.Configurations;

public class MeetingAttendeeConfiguration :IEntityTypeConfiguration<MeetingAttendee>
{
    public void Configure(EntityTypeBuilder<MeetingAttendee> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => new { x.MeetingId, x.MemberId }).IsUnique();
        builder.HasOne(x => x.Meeting)
            .WithMany(x => x.Attendees)
            .HasForeignKey(x => x.MeetingId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(x => x.Member)
            .WithMany(x => x.MeetingAttendances)
            .HasForeignKey(x => x.MemberId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
