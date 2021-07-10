using System;
using System.Threading.Tasks;

namespace _Async
{
    class Program
    {
        static void Main(string[] args)
        {
            // como o processo X é async, a Thread não aguarda a sua conclusão e executa o processo Y 
            ProcessoX();

            ProcessoY();
            Console.ReadLine();
        }

        static async void ProcessoX()
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
