using System;

namespace _Params
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5] { 1, 2, 3, 4, 5 };

            UseParams(1, 2, 3, 4, 5, 'a');
            NotUseParams(array);
        }
        public static void NotUseParams(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }


        // a palavra reservada 'params' coloca todos os parametros enviados em um array:
        public static void UseParams(params dynamic[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
