using System;
using System.Collections.Generic;
using System.Linq;

namespace _Take
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = GetItems();
            Console.WriteLine(string.Join(" | ", items));

            var items2 = GetItems().Take(3);  // pega os itens do primeiro até o indice 3
            Console.WriteLine(string.Join(" | ", items2));
        }

        static List<string> GetItems()
        {
            return new List<string>(){
                "item 01",
                "item 02",
                "item 03",
                "item 04",
                "item 05",
                "item 06",
            };
        }
    }
}
