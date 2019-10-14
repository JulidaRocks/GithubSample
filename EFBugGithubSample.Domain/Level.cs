using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain
{
    public class Level : Entity
    {
        public int Rank
        {
            get; private set;
        }
        public float RequiredPoints
        {
            get; private set;
        }
        public virtual ICollection<UserLevelAdvancement> UserAdvancements
        {
            get; private set;
        } =
            new HashSet<UserLevelAdvancement>();

        public Level(Guid id, int rank, float requiredPoints) : base(id)
        {
            this.Rank = rank;
            this.RequiredPoints = requiredPoints;
        }
    }
}
