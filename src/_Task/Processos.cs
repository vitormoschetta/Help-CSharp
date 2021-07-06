using System;

namespace _Task
{
    public static class Processos
    {
        public static void ProcessoA()
        {   
            for (long i = 0; i < 500000000; i++)
            {
                
            }
            Console.WriteLine("Processo A concluído!");
        }

        public static void ProcessoB()
        {
            for (long i = 0; i < 500000000; i++)
            {
                
            }
            Console.WriteLine("Processo B concluído!");
        }

        public static void ProcessoC()
        {
            for (long i = 0; i < 500000000; i++)
            {
                
            }
            Console.WriteLine("Processo C concluído!");
        }
    }
}