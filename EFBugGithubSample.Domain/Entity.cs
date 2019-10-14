using System;

namespace EFBugGithubSample.Domain
{
    public abstract class Entity
    {
        public Guid Id
        {
            get; protected set;
        }
        public DateTimeOffset? ModifiedAt
        {
            get; protected set;
        }
        public virtual User ModifiedBy
        {
            get; protected set;
        }
        public Guid? ModifiedById
        {
            get; protected set;
        }
        public bool Deleted
        {
            get; private set;
        }

        protected Entity(Guid id)
        {
            this.Id = id;
        }

        public void Modify(Guid userId)
        {
            if (userId != Guid.Empty)
            {
                this.ModifiedById = userId;
            }

            this.ModifiedAt = DateTimeOffset.UtcNow;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
    }
}
