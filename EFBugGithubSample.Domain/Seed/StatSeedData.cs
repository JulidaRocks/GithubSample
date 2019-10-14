using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain.Seed
{
    public static class StatSeedData
    {
        public static List<Stat> Stats => new List<Stat>
                {
                    TestStat
                };

        public static Stat TestStat => new Stat(Guid.Parse("44E93117-DBAD-47B2-BC8C-E672EA1FB5BE"), "Name", 1);
    }
}
