using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Classe Normal...");
            Normal.Execute();

            Console.WriteLine("\nExecutando Classe UsingThreads...");
            UsingThreads.Execute();      

        }

    }
}
