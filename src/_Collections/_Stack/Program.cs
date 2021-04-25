using System;
using System.Collections.Generic;

namespace _Stack
{
    // Stack é uma pilha onde o último elemento a entrar é o primeiro a sair (Pop)
    class Program
    {
         static Stack<string> queueOne;
        static void Main(string[] args)
        {
            queueOne = new Stack<string>();

            SetQueueOne();            
            Console.WriteLine(string.Join(" | ", queueOne));

            // Dequeue retorna e remove o elemento mais antigo da coleção
            var value01 = queueOne.Pop();            
            Console.WriteLine(string.Join(" | ", queueOne));

            // Push adiciona um novo elemento na coleção
            queueOne.Push("six");
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
            queueOne.Push("one");
            queueOne.Push("two");
            queueOne.Push("three");
            queueOne.Push("four");
            queueOne.Push("five");
        }
    }
}
