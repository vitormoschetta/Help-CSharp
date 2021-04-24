using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Degug
{
    class Program
    {
        static void Main(string[] args)
        {           

                                 
        }
    }

    class Product
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
