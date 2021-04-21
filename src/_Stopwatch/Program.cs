using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace _Stopwatch
{
    public class Program
    {
        static void Main(string[] args)
        {            
            var stopwatch = new Stopwatch();            
            
            Console.WriteLine("Iniciando contagem de 3 segundos...");
            stopwatch.Start();

            Thread.Sleep(3000);             

            stopwatch.Stop();
            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");

            stopwatch.Restart();

        }
    }
}
