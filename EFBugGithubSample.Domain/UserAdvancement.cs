using System;

namespace EFBugGithubSample.Domain
{
    public enum AdvancementTypes
    {
        Badge,
        Level
    }

    public abstract class UserAdvancement
    {
        protected UserAdvancement(AdvancementTypes advancementType, Guid userId, DateTime date)
        {
            this.AdvancementType = advancementType;
            this.UserId = userId;
            this.Date = date != DateTime.MinValue ? date : DateTime.Today;
        }
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime Date
        {
            get; private set;
        }
        public AdvancementTypes AdvancementType
        {
            get; private set;
        }
        public Guid UserId
        {
            get; private set;
        }
        public virtual User User
        {
            get; private set;
        }
    }
}
