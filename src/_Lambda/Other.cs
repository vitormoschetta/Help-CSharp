using System;
using System.Linq;

namespace _Lambda
{
    public class Other
    {
        // Problema: imprimir, em uma única linha, cada número da lista de 'numbers' ao quadrado.
        static int[] numbers = { 2, 3, 4, 5 };

        public static void Execute()
        {
            Solution01();
            Solution02();
            Solution03();
            Solution04();
        }


        // Resolvendo com For
        private static void Solution01()
        {
            var numbersSquare = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersSquare[i] = numbers[i] * numbers[i];
            }

            Console.WriteLine(string.Join(" ", numbersSquare));
        }


        // Resolvendo com Foreach
        private static void Solution02()
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


        // Resolvendo com Linq puro
        private static void Solution03()
        {
            var numbersSquare = from item in numbers 
                                select item * item;

            Console.WriteLine("\n"+ string.Join(" ", numbersSquare));
        }


        // Resolvendo com Linq to Lambda Expressions
        private static void Solution04()
        {
            var numbersSquare = numbers.Select(x => x * x);  

            Console.WriteLine("\n"+ string.Join(" ", numbersSquare));
        }
        
        


        //Obs: As soluções Linq e Lambda utilizam um loop por baixo, como se fosse um for ou foreach.
    }
}