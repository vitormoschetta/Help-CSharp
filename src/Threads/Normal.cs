using System;
using System.Threading;

namespace Threads
{
    public class Normal
    {
        public static void Execute()
        {
            MeuMetodoA();
            MeuMetodoB();            
        }

        private static void MeuMetodoA()
        {            
            Thread.Sleep(2000);
            
            Console.WriteLine("Metodo A");            
        }

        private static void MeuMetodoB()
        {                                    
            Console.WriteLine("Metodo B");            
        }
    }
}