using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain.Seed
{
    public static class BadgeSeedData
    {
        public static List<Badge> Badges => new List<Badge>
                {
                    TestBadge1
                };

        public static Badge TestBadge1 => new Badge(
                    Guid.Parse("4C8BA004-21FA-4533-803E-096A80022CE9"),
                    StatSeedData.TestStat.Id,
                    "Name",
                    "Hint",
                    1,
                    1);
    }
}
