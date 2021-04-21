using System;

namespace Extras
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List();
            bool exist = lista.ExisteItemMesmoNome();
            Console.WriteLine(exist);
        }
    }
}
