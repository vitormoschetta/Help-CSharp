using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shared;

namespace _Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteProcessos();
            ExecuteProcessosAsync2();
        }

        static void ExecuteProcessos()
        {
            Cronometro.Start();
            Console.WriteLine("\n====== Iniciando processos =======");

            Processos.ProcessoA();
            Processos.ProcessoB();
            Processos.ProcessoC();

            Cronometro.Stop();
        }
        static void ExecuteProcessosAsync()
        {
            Cronometro.Start();
            Console.WriteLine("\n======= Iniciando processos assincronos =======");

            var tarefas = new Task[3];

            tarefas[0] = Task.Run(() => Processos.ProcessoA());
            tarefas[1] = Task.Run(() => Processos.ProcessoB());
            tarefas[2] = Task.Run(() => Processos.ProcessoC());

            Task.WaitAll(tarefas);

            Cronometro.Stop();
        }

        static void ExecuteProcessosAsync2()
        {
            Cronometro.Start();
            Console.WriteLine("\n======= Iniciando processos assincronos =======");

            var tarefas = new Task[3];
            tarefas[0] = ProcessosAsync.ProcessoA();
            tarefas[1] = ProcessosAsync.ProcessoB();
            tarefas[2] = ProcessosAsync.ProcessoC();
        
            Task.WaitAll(tarefas);
        }

        static void ExecuteProcessosAsync3()
        {
            Cronometro.Start();
            Console.WriteLine("\n======= Iniciando processos assincronos =======");

            Console.WriteLine(ProcessosComRetorno.ProcessoA());
            Console.WriteLine(ProcessosComRetorno.ProcessoA());
            Console.WriteLine(ProcessosComRetorno.ProcessoA());

            Cronometro.Stop();
        }
    }
}
