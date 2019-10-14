using System;

namespace EFBugGithubSample.Domain
{
    public class UserBadgeAdvancement : UserAdvancement
    {
        public UserBadgeAdvancement(Guid userId, Guid badgeId, DateTime date)
            : base(AdvancementTypes.Badge, userId, date)
        {
            this.BadgeId = badgeId;
        }

        public Guid BadgeId
        {
            get; private set;
        }
        public virtual Badge Badge
        {
            get; private set;
        }
    }
}
