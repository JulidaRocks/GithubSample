using EFBugGithubSample.Domain;
using EFBugGithubSample.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBugGithubSample.DataAccess.Configurations
{
    public class UserLevelAdvancementConfiguration : IEntityTypeConfiguration<UserLevelAdvancement>
    {
        public void Configure(EntityTypeBuilder<UserLevelAdvancement> builder)
        {
            builder.HasData(UserAdvancementSeedData.UserLevelAdvancements);
        }
    }
}
