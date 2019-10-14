using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain
{
    public class Stat : Entity
    {
        public string Name
        {
            get; private set;
        }
        public float PointsPerValue
        {
            get; private set;
        }
        public virtual ICollection<StatEntry> StatEntries
        {
            get; private set;
        } =
            new HashSet<StatEntry>();
        public virtual ICollection<Badge> Badges
        {
            get; private set;
        } =
            new HashSet<Badge>();

        public Stat(
            Guid id,
            string name,
            float pointsPerValue) : base(id)
        {
            this.Name = name;
            this.PointsPerValue = pointsPerValue;
        }
    }
}
