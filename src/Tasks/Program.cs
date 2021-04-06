using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apenas uma Thread executando os métodos de forma síncrona:
            Metodos.MetodoA();
            Metodos.MetodoB();
            Metodos.MetodoC();


            Console.WriteLine("\n");
                      


            // Executando as Tasks de forma assíncrona:
            Task taskA = new Task(Metodos.MetodoA);
            Task taskB = new Task(Metodos.MetodoB);
            Task taskC = new Task(Metodos.MetodoC);
            taskA.Start();
            taskB.Start();
            taskC.Start();
            taskA.Wait();
            taskB.Wait();
            taskC.Wait();


            Console.WriteLine("\n");


            // Executando as Tasks de forma síncrona:
            taskA = new Task(Metodos.MetodoA);
            taskB = new Task(Metodos.MetodoB);
            taskC = new Task(Metodos.MetodoC);

            taskA.Start();
            taskA.Wait();

            taskB.Start();
            taskB.Wait();

            taskC.Start();                    
            taskC.Wait();
        }
    }
}
