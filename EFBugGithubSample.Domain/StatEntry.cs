using System;

namespace EFBugGithubSample.Domain
{
    public class StatEntry : Entity
    {
        public Guid StatId
        {
            get; private set;
        }
        public virtual Stat Stat
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
        public float Value
        {
            get; private set;
        }
        public float Points => 10;
        public DateTime QueryDate
        {
            get; private set;
        }
        public string ReferenceKey
        {
            get; private set;
        }

        public StatEntry(
            Guid id,
            Guid statId,
            Guid userId,
            DateTime queryDate,
            float value,
            string referenceKey) : base(id)
        {
            this.StatId = statId;
            this.UserId = userId;
            this.Value = value;
            this.ReferenceKey = referenceKey;
            this.QueryDate = queryDate;
        }
    }
}
