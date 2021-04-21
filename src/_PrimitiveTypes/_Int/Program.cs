using System;
using System.Collections.Generic;
using System.Linq;

namespace _Int
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new ItemsString().simpleArraySum();
            Console.WriteLine(string.Join(", ", lista));
        }
    }

    public class ItemsString
    {
        public string stringLIst;
        public ItemsString()
        {
            stringLIst = "2 5 7 9";
        }
        public List<int> simpleArraySum()
        {
            List<int> listaInt = stringLIst.Split(' ')
                                    .ToList() // até aqui pega uma List<string>
                                    .Select(x => Convert.ToInt32(x)) // até aqui pega um IEnumerable<int>
                                    .ToList(); // até aqui um List<int>
            return listaInt;
        }
    }
}
