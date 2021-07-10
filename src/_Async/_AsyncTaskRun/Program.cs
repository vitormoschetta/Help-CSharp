using System;
using System.Threading;
using System.Threading.Tasks;

namespace _AsyncTaskRun
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
            // caso não de para utilizar a palavra podemos usar o await Task.Run em substituição ao await:         
            await Task.Run(() =>
            {
                Console.WriteLine("Iniciando processo X...");
                Thread.Sleep(5000);
                Console.WriteLine("Fim do processo X");
            });

        }

        static void ProcessoY()
        {
            Console.WriteLine("Iniciando processo Y...");
            Console.WriteLine("Fim do processo Y");
        }
    }
}
