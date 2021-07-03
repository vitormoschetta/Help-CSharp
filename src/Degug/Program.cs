﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Degug
{
    class Program
    {
        public enum EStatus
        {
            created = 1,
            updated = 2,
            deleted = 3
        }
        static void Main(string[] args)
        {
            var items = ReturnList().Skip(3);
            Console.WriteLine(string.Join(" | ", items));
        }

        static List<string> ReturnList()
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
