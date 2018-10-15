using System;

namespace Livraria.Domain.Core.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

    }
}
