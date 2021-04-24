using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Degug
{
    class Program
    {
        // Problema: imprimir, em uma única linha, cada número da lista de 'numbers' ao quadrado.
        static int[] numbers = { 2, 3, 4, 5 };

        static void Main(string[] args)
        {
            Solution01();
            Solution02();
            Solution03();
            Solution04();
        }


        // Resolvendo com For
        static void Solution01()
        {
            var numbersSquare = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersSquare[i] = numbers[i] * numbers[i];
            }

            Console.WriteLine(string.Join(" ", numbersSquare));
        }


        // Resolvendo com Foreach
        static void Solution02()
        {
            var numbersSquare = new int[4];
            int i = 0;

            foreach (var item in numbers)
            {
                numbersSquare[i] = item * item;
                i++;
            }

            Console.WriteLine("\n"+ string.Join(" ", numbersSquare));
        }


        // Resolvendo com Lambda Expressions
        static void Solution03()
        {
            var numbersSquare = numbers.Select(x => x * x);  

            Console.WriteLine("\n"+ string.Join(" ", numbersSquare));
        }


        // Resolvendo com Linq
        static void Solution04()
        {
            var numbersSquare = from item in numbers 
                                select item * item;

            Console.WriteLine("\n"+ string.Join(" ", numbersSquare));
        }
        


        //Obs: As soluções Linq e Lambda utilizam um loop por baixo, como se fosse um for ou foreach.
    }

}
