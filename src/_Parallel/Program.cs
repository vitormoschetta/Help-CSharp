using System;
using System.Threading;
using System.Threading.Tasks;
using Shared;

namespace _Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            ExecuteAsync();
            ExecuteLoop();
        }


        static void Execute()
        {
            Cronometro.Start();

            Processos.ProcessoA();
            Processos.ProcessoB();
            Processos.ProcessoC();

            Cronometro.Stop();
        }

        static void ExecuteAsync()
        {
            Cronometro.Start();

            Parallel.Invoke(
                () => Processos.ProcessoA(),
                () => Processos.ProcessoB(),
                () => Processos.ProcessoC());

            Cronometro.Stop();
        }


        static void ExecuteLoop()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Test {0}", i);
            });
            Console.WriteLine("Finished");
        }
    }
}
