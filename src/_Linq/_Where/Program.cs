using System;
using System.Collections.Generic;
using System.Linq;

namespace _Where
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = GetItems();
            Console.WriteLine(string.Join(" | ", items));

            // a cláusula where funciona como um filtro: 
            var items2 = GetItems().Where(x => x.Contains("01"));
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
                "product 01",
                "product 02",
                "product 03",
                "product 04",
                "product 05",
                "product 06",
            };
        }
    }
}
