using System;
using System.Threading.Tasks;

namespace Shared
{
    public static class ProcessosAsync
    {
        public static async Task ProcessoA()
        {
            await Task.Run(() =>
            {
                for (long i = 0; i < 900000000; i++) { }
                Console.WriteLine("Processo A concluído!");
            });

        }

        public static async Task ProcessoB()
        {
            await Task.Run(() =>
            {
                for (long i = 0; i < 900000000; i++) { }
                Console.WriteLine("Processo B concluído!");
            });
        }

        public static async Task ProcessoC()
        {
            await Task.Run(() =>
            {
                for (long i = 0; i < 900000000; i++) { }
                Console.WriteLine("Processo C concluído!");
            });
        }
    }
}