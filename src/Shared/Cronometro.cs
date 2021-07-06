using System;
using System.Diagnostics;

namespace Shared
{
    public static class Cronometro
    {
        private static Stopwatch stopwatch;

        public static void Start()
        {
            stopwatch = new Stopwatch();   
            stopwatch.Start();           
        }

        public static void Stop()
        {            
            stopwatch.Stop();
            Console.WriteLine($"\nTempo decorrido: {stopwatch.Elapsed}\n");
            stopwatch.Restart();
        }
    }
}