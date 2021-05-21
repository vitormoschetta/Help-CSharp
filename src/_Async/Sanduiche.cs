using System;
using System.Threading;

namespace _Async
{
    public static class Sanduiche
    {
        public static void Execute()
        {
            AddPao();
            AddQueijo();
            AddPresunto();
        }
        private static void AddPao()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adicionado Pao Integral");
        }

        private static void AddQueijo()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adicionado Queijo Mussarela");
        }

        private static void AddPresunto()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adicionado Apresuntado Defumado");
        }
    }
}