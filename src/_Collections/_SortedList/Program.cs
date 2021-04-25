using System;
using System.Collections.Generic;

namespace _SortedList
{
    // SortedList é similar ao Dictionary, contendo boa parte dos métodos de Dictionary..
    // Uma diferença básica é o acesso aos valores pelo index que o SortedList possibilita.
    class Program
    {
        static SortedList<string, string> sortedList;
        static void Main(string[] args)
        {
            SetSortedList();
            ExploreMethods();            
        }


        static void SetSortedList()
        {
            sortedList = new SortedList<string, string>();

            sortedList.Add("01", "C#");
            sortedList.Add("02", "Python");
            sortedList.Add("03", "NodeJS");
        }

        static void ExploreMethods()
        {
            var index = sortedList.IndexOfValue("C#"); //0

            sortedList.RemoveAt(index);

            Console.WriteLine(string.Join("; ", sortedList));            
        }
  
    }
}
