﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _Skip
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = GetItems();
            Console.WriteLine(string.Join(" | ", items));

            var items2 = GetItems().Skip(3); // pega os itens do indice 3 pra frente
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
