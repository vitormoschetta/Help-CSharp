using System;

namespace _Equal
{
    class Program
    {
        // Equal retorna true na comparação de dois objetos caso a instância seja a mesma
        static void Main(string[] args)
        {
            // Comparação de Instância
            var instanciaA = new Instancia(1, 4);
            var instanciaB = new Instancia(1, 5);            
            Console.WriteLine(Equals(instanciaA, instanciaA)); // true
            Console.WriteLine(Equals(instanciaA, instanciaB)); // false       


            // Comparação de Valores
            var objetoA = new Objeto(2, 3);
            var objetoB = new Objeto(2, 3);
            Console.WriteLine(objetoA.Igual(objetoB)); // true

            var objetoC = new Objeto(2, 4);            
            Console.WriteLine(objetoA.Igual(objetoC)); // false
        }
    }
}
