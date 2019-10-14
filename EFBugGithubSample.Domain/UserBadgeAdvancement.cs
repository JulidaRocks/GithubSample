using System;

namespace EFBugGithubSample.Domain
{
    public class UserBadgeAdvancement : UserAdvancement
    {
        public UserBadgeAdvancement(Guid userId, Guid badgeId, DateTime date, float points)
            : base(AdvancementTypes.Badge, userId, date)
        {
            this.BadgeId = badgeId;
            this.Points = points;
        }

        public Guid BadgeId
        {
            get; private set;
        }
        public virtual Badge Badge
        {
            get; private set;
        }
        public float Points
        {
            get; private set;
        }
    }
}
