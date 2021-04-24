using System;
using System.Collections.Generic;
using System.Linq;

namespace _ClassUsing
{
    class Program
    {
        static void Main()
        {
            FilaString();
            FilaProduct();
        }


        static void FilaString()
        {
            List<string> items = new List<string>()
            {
                "one",
                "two",
                "three"
            };

            var fila = new Fila<string>(items);
            var item = fila.ConsomeFila();
            var item02 = fila.ConsomeFila();

            Console.WriteLine(string.Join(" | ", fila.GetElements()));
        }

        static void FilaProduct()
        {
            List<Product> items = new List<Product>()
            {
                new Product("productA"),
                new Product("ProductB"),
                new Product("ProductC") 
            };

            var fila = new Fila<Product>(items);
            var item = fila.ConsomeFila();
            var item02 = fila.ConsomeFila();

            Console.WriteLine(string.Join(" | ", fila.GetElements().Select(x => x.Name)));
        }
    }
    
}
