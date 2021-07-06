using System;
using System.Diagnostics;

namespace Shared
{
    public static class Processos
    {
        public static void ProcessoA()
        {
            for (long i = 0; i < 900000000; i++)
            {

            }
            Console.WriteLine("Processo A concluído!");
        }

        public static void ProcessoB()
        {
            for (long i = 0; i < 900000000; i++)
            {

            }
            Console.WriteLine("Processo B concluído!");
        }

        public static void ProcessoC()
        {
            for (long i = 0; i < 900000000; i++)
            {

            }
            Console.WriteLine("Processo C concluído!");
        }
    }
}