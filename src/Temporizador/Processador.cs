using System;
using System.Diagnostics;

namespace Temporizador
{
    public static class Processador
    {
        public static void processar()
        {			
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var i = 0; i < 10000; i++){
                Console.WriteLine("Valor de i é: " + i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            
            stopwatch.Restart();
            //Usar novamente stopwatch
        }
    }
}