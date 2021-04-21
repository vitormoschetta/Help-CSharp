using System;
using System.Threading;
using System.Threading.Tasks;

namespace _Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteMetodos();
            //ExecuteMetodosComRetorno();
        }

        static void ExecuteMetodos()
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


            // Outra forma de executar Tasks de forma assíncrona:
            var tarefas = new Task[3];

            tarefas[0] = Task.Run(() => Metodos.MetodoA());
            tarefas[1] = Task.Run(() => Metodos.MetodoB());
            tarefas[2] = Task.Run(() => Metodos.MetodoC());

            Task.WaitAll(tarefas);


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



        static void ExecuteMetodosComRetorno()
        {
            // Apenas uma Thread executando os métodos de forma síncrona:
            Console.WriteLine(MetodosComRetorno.MetodoA().Result);
            Console.WriteLine(MetodosComRetorno.MetodoB().Result);
            Console.WriteLine(MetodosComRetorno.MetodoC().Result);


            Console.WriteLine("\n");
        
        }
    }
}
