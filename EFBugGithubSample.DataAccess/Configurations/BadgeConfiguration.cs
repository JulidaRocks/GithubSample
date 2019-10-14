using EFBugGithubSample.Domain;
using EFBugGithubSample.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBugGithubSample.DataAccess.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder
              .HasData(BadgeSeedData.Badges);

            builder
                .HasMany(e => e.UserAdvancements)
                .WithOne(a => a.Badge)
                .HasForeignKey(a => a.BadgeId);
        }
    }
}
