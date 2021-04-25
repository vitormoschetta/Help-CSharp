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
            Console.WriteLine(testForEquality(1,1));
        }

        static Func<int, int, bool> testForEquality = (x, y) => x == y;
        

    }

}
