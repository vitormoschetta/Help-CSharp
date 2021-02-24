using System;

namespace NameOf
{
    public class Product
    {
        public Product(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        
        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}