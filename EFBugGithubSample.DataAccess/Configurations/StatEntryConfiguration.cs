using EFBugGithubSample.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBugGithubSample.DataAccess.Configurations
{
    public class StatEntryConfiguration : IEntityTypeConfiguration<StatEntry>
    {
        public void Configure(EntityTypeBuilder<StatEntry> builder)
        {
            builder
                .HasIndex(e => e.QueryDate);

            builder.HasOne(e => e.User)
                .WithMany(u => u.StatEntries)
                .HasForeignKey(e => e.UserId);

            builder.HasOne(e => e.Stat)
                .WithMany(u => u.StatEntries)
                .HasForeignKey(e => e.StatId);

            builder
                .Ignore(e => e.Points);
        }
    }
}
