using System;

namespace _Skip
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = GetList();
            Console.WriteLine(string.Join(" | ", items));

            items = GetList().Skip(3); // pega os itens do indice 3 pra frente
            Console.WriteLine(string.Join(" | ", items));
        }

        static List<string> GetList()
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
