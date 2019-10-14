using EFBugGithubSample.Domain;
using EFBugGithubSample.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBugGithubSample.DataAccess.Configurations
{
    public class StatConfiguration : IEntityTypeConfiguration<Stat>
    {
        public void Configure(EntityTypeBuilder<Stat> builder)
        {
            builder
                .HasData(StatSeedData.Stats);
        }
    }
}
