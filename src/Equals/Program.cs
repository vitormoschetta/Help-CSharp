using System;
using Equals;

namespace equals
{
    class Program
    {
        static void Main(string[] args)
        {
            var instanciaA = new Instancia(1, 5);
            var instanciaB = new Instancia(1, 5);

            Console.WriteLine(Equals(instanciaA, instanciaA)); // true
            Console.WriteLine(Equals(instanciaA, instanciaB)); // false       

            var objetoA = new Objeto(2, 3);
            var objetoB = new Objeto(2, 3);
            Console.WriteLine(objetoA.Igual(objetoB)); // true

            var objetoC = new Objeto(2, 4);            
            Console.WriteLine(objetoA.Igual(objetoC)); // false
        }
    }
}
