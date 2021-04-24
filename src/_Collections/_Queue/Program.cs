using System;
using System.Collections.Generic;

namespace _Queue
{
    // Queue é uma fila onde o primeiro elemento a entrar é o primeiro a sair (Dequeue)
    class Program
    {        
        static Queue<string> queueOne;
        static void Main(string[] args)
        {
            queueOne = new Queue<string>();

            SetQueueOne();            
            Console.WriteLine(string.Join(" | ", queueOne));

            // Dequeue retorna e remove o elemento mais antigo da coleção
            var value01 = queueOne.Dequeue();            
            Console.WriteLine(string.Join(" | ", queueOne));

            // Enqueue adiciona um novo elemento na coleção
            queueOne.Enqueue("six");
            Console.WriteLine(string.Join(" | ", queueOne));

            // Peek retorna o elemento mais antigo da coleção, sem removê-lo
            var valueMaisAntigo = queueOne.Peek();
            Console.WriteLine(valueMaisAntigo);
            Console.WriteLine(string.Join(" | ", queueOne));

            if (queueOne.Contains("six"))
                Console.WriteLine("\nChegamos ao fim");
        }

        static void SetQueueOne()
        {            
            queueOne.Enqueue("one");
            queueOne.Enqueue("two");
            queueOne.Enqueue("three");
            queueOne.Enqueue("four");
            queueOne.Enqueue("five");
        }


    }
}
