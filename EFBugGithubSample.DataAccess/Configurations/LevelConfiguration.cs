using EFBugGithubSample.Domain;
using EFBugGithubSample.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBugGithubSample.DataAccess.Configurations
{
    public class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasData(LevelSeedData.Levels);

            builder
                .HasMany(e => e.UserAdvancements)
                .WithOne(a => a.Level)
                .HasForeignKey(a => a.LevelId);
        }
    }
}
