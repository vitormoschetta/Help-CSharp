using System;
using System.Collections.Generic;

namespace _Queue
{
    // Queue é uma fila onde o primeiro elemento a entrar é o primeiro a sair (Dequeue)
    // (FIFO – First-In-First-Out)
    class Program
    {
        static Queue<string> queue;
        static void Main(string[] args)
        {
            Setqueue();
            ExecuteDequeue();
            ExecuteEnqueue();
            ExecutePeek();
        }

        static void Setqueue()
        {
            queue = new Queue<string>();

            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");
            queue.Enqueue("five");

            Console.WriteLine(string.Join(" | ", queue));
        }

        static void ExecuteDequeue()
        {
            // Dequeue retorna e remove o elemento mais antigo da coleção
            var value01 = queue.Dequeue();
            Console.WriteLine(string.Join(" | ", queue));
        }

        static void ExecuteEnqueue()
        {
            // Enqueue adiciona um novo elemento na coleção
            queue.Enqueue("six");
            Console.WriteLine(string.Join(" | ", queue));
        }

        static void ExecutePeek()
        {   
            // Peek retorna o elemento mais antigo da coleção, sem removê-lo            
            Console.WriteLine(queue.Peek());
            Console.WriteLine(string.Join(" | ", queue));
        }


    }
}
