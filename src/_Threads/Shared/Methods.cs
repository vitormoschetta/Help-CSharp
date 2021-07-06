using System;
using System.Threading;

namespace Shared
{
    public static class Methods
    {
        public static void MetodoA()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Metodo A");
        }

        public static void MetodoB()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Metodo B");
        }

        public static void MetodoC()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Metodo C");
        }
    }
}
