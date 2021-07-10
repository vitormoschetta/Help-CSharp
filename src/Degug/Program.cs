using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace Degug
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 5;

            Aguardar(tempo);

            Console.WriteLine("Já passou {0} segundos", tempo);
            Console.ReadLine();
        }

        static async void Aguardar(int tempo)
        {
            Console.WriteLine("Iniciando...");
            await Task.Delay(TimeSpan.FromSeconds(tempo));
            Console.WriteLine("Fim...");
        }
    }
}
