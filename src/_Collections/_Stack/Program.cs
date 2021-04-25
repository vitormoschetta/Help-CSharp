using System;
using System.Collections.Generic;

namespace _Stack
{
    // Stack é uma pilha onde o último elemento a entrar é o primeiro a sair (Pop)
    // (LIFO – Last-In-First-Out)
    class Program
    {
        static Stack<string> stack;
        static void Main(string[] args)
        {
            SetStack();
            ExecutePop();
            ExecutePush();
            ExecutePeek();
        }

        static void SetStack()
        {
            stack = new Stack<string>();

            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");
            stack.Push("five");

            Console.WriteLine(string.Join(" | ", stack));
        }

        static void ExecutePop()
        {
            // Pop retorna e remove o elemento mais antigo da coleção
            var value01 = stack.Pop();
            Console.WriteLine(string.Join(" | ", stack));
        }

        static void ExecutePush()
        {
            // Push adiciona um novo elemento na coleção
            stack.Push("six");
            Console.WriteLine(string.Join(" | ", stack));
        }

        static void ExecutePeek()
        {   
            // Peek retorna o elemento mais antigo da coleção, sem removê-lo            
            Console.WriteLine(stack.Peek());
            Console.WriteLine(string.Join(" | ", stack));
        }
    
    }
}
