using System;
using System.Collections.Generic;

namespace EFBugGithubSample.Domain
{
    public class User : Entity
    {
        public string Email
        {
            get; private set;
        }
        public string Name
        {
            get; private set;
        }

        public virtual ICollection<StatEntry> StatEntries { get; private set; } = new HashSet<StatEntry>();
        public virtual ICollection<UserAdvancement> Advancements { get; private set; } = new HashSet<UserAdvancement>();

        public User(Guid id, string email, string name) : base(id)
        {
            this.Email = email;
            this.Name = name;
        }
    }
}
