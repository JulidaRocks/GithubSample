using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain.Seed
{
    public static class UserAdvancementSeedData
    {
        public static IEnumerable<UserLevelAdvancement> UserLevelAdvancements => new List<UserLevelAdvancement>
                {
                    TestLevelAdvancement,
                };

        public static UserLevelAdvancement TestLevelAdvancement => new UserLevelAdvancement(UserSeedData.TestUser.Id, LevelSeedData.Level1.Id, DateTime.Today);
    }

}