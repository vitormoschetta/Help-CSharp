using System;
using Problemas.Listas;

namespace Problemas
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ProblemasComListas();
            bool exist = lista.ExisteItemMesmoNome();
            Console.WriteLine(exist);
        }
    }
}
