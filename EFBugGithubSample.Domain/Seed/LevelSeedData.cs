using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain.Seed
{
    public static class LevelSeedData
    {
        public static List<Level> Levels => new List<Level>
                {
                    Level1
                };

        public static Level Level1 => new Level(Guid.Parse("94AD7946-3ACC-4B54-80D6-954FFF8802A4"), 1, 0);
    }
}
