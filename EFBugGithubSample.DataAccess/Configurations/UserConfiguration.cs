using EFBugGithubSample.Domain;
using EFBugGithubSample.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBugGithubSample.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasIndex(e => e.Email)
                .IsUnique();

            builder
                .HasData(UserSeedData.Users);

            builder
                .HasMany(e => e.Advancements)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);
        }
    }
}
