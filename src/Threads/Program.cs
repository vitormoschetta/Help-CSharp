using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apenas uma Thread executando os métodos de forma síncrona:
            Metodos.MetodoA();
            Metodos.MetodoB();
            Metodos.MetodoC();

            Console.WriteLine("\n");

            // Uma Thread para cada método (execução parelela):
            var threadA = new Thread(Metodos.MetodoA); 
            var threadB = new Thread(Metodos.MetodoB); 
            var threadC = new Thread(Metodos.MetodoC); 
            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

    }
}
