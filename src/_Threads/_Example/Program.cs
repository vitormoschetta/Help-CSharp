﻿using System;
using Shared;

namespace _Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Cronometro.Start();

            // Apenas uma Thread executando os métodos de forma síncrona:
            Processos.ProcessoA();
            Processos.ProcessoB();
            Processos.ProcessoC();

            Console.WriteLine("\nProceso concluído!");
            
            Cronometro.Stop();
        }
    }
}
