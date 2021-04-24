using System;

namespace _ClassUsing
{
    public class Product
    {
        public Product()
        { 
            Id = Guid.NewGuid();
        }
        public Product(string name)
        { 
            Id = Guid.NewGuid();
            Name = name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}