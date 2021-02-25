using System;
using System.Threading;

namespace Threads
{
    public class UsingThreads
    {
        public static void Execute()
        {
            var thread = new Thread(MeuMetodoA);
            thread.Start();

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