using System;

namespace EFBugGithubSample.Domain
{
    public class UserLevelAdvancement : UserAdvancement
    {
        public UserLevelAdvancement(Guid userId, Guid levelId, DateTime date)
            : base(AdvancementTypes.Level, userId, date)
        {
            this.LevelId = levelId;
        }

        public Guid LevelId
        {
            get; private set;
        }
        public virtual Level Level
        {
            get; private set;
        }
    }
}
