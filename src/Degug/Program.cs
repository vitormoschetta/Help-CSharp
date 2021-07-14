using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace Degug
{
    class Program
    {
        static void Main(string[] args)
        {
            var prodA = new Product("Manteiga");
            Console.WriteLine(prodA.Name);

            var prodB = prodA;
            Console.WriteLine(prodB.Name);

            prodA.Name = "Leite";
            Console.WriteLine(prodA.Name);
            Console.WriteLine(prodB.Name);

        }
    }

    public struct Product
    {
        public Product(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
