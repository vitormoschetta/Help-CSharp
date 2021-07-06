using System;
using Shared;

namespace _Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apenas uma Thread executando os métodos de forma síncrona:
            Methods.MetodoA();
            Methods.MetodoB();
            Methods.MetodoC();

            Console.WriteLine("\nProceso concluído!");
        }
    }
}
