using System;
using System.Threading.Tasks;

namespace _Await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // await faz a thread aguardar o fim do processo X para poder prosseguir
            await ProcessoX();

            ProcessoY();
            Console.ReadLine();
        }

        static async Task ProcessoX()
        {
            Console.WriteLine("Iniciando processo X...");
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("Fim do processo X");
        }

        static void ProcessoY()
        {
            Console.WriteLine("Iniciando processo Y...");            
            Console.WriteLine("Fim do processo Y");
        }
    }
}
