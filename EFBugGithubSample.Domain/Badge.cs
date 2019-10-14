using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain
{
    public class Badge : Entity
    {
        public string Name
        {
            get; private set;
        }
        public string Hint
        {
            get; private set;
        }
        public float RequiredValue
        {
            get; private set;
        }
        public float Points
        {
            get; private set;
        }
        public Guid? StatId
        {
            get; private set;
        }
        public virtual Stat Stat
        {
            get; private set;
        }
        public virtual ICollection<UserBadgeAdvancement> UserAdvancements
        {
            get; private set;
        } =
            new HashSet<UserBadgeAdvancement>();

        public Badge(
            Guid id,
            Guid? statId,
            string name,
            string hint,
            float requiredValue,
            float points) : base(id)
        {
            this.StatId = statId;
            this.Name = name;
            this.Hint = hint;
            this.RequiredValue = requiredValue;
            this.Points = points;
        }
    }
}
