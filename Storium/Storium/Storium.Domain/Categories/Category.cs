

using Storium.Domain.Abstraction;
using Storium.Domain.Products;
using Storium.Domain.Shared;

namespace Storium.Domain.Category
{
    public sealed class Category : Entity
    {
        public Name Name { get; private set; }
        public Category(Guid id) : base(id)
        {
        }

        public Category(Guid id, Name name) : base(id)
        {
            Name = name;
        }

        public void ChangeName(string name) {
            Name = new(name);
        }

        public ICollection<Product> Products { get; private set; }

    }
}
