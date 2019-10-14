using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain.Seed
{
    public static class UserSeedData
    {
        public static IEnumerable<User> Users => new List<User>
                {
                    TestUser
                };

        public static User TestUser => new User(
                    Guid.Parse("1af91c5c-d954-4830-9c21-2ef87b0f133b"),
                    "test@test.com",
                    "Test User");
    }

}