using System;
using System.Threading;

namespace Threads
{
    public class UsingThreads
    {
        public static void Execute()
        {
            var thread = new Thread(MeuMetodoA);            

            MeuMetodoB();        

            thread.Start();
        }

        private static void MeuMetodoA()
        {                                    
            Console.WriteLine("Metodo A");            
        }

        private static void MeuMetodoB()
        {                                    
            Console.WriteLine("Metodo B");            
        }
    }
}