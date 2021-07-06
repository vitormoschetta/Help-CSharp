using System;
using System.Threading;
using Shared;

namespace _IsAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui estamos criando uma Thread para cada método, ou seja, eles irão executar em paralelo:
            var threadA = new Thread(Methods.MetodoA); 
            var threadB = new Thread(Methods.MetodoB); 
            var threadC = new Thread(Methods.MetodoC); 
            threadA.Start();
            threadB.Start();
            threadC.Start();

            // enquanto a thread xpto não concluir o processamento:
            while (threadA.IsAlive || threadB.IsAlive || threadC.IsAlive)
            {
                // Esse loop pode ficar rodando inúmeras vezes sem necessidade e consumindo processamento.
                // Logo, fazer os processos dessas threads dormirem, nem q seja por poucos miléssimos de segundo irá reduzir o número de processamento
                // e ganhar desempenho:
                Thread.Sleep(250);
            }

            Console.WriteLine("\nProceso concluído!");
        }
    }
}
