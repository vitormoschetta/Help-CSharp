using System;

namespace _Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diferença de dois inteiros sempre em um inteiro POSITIVO:
            int x = 15;
            int y = 5;

            var result = Math.Abs(y - x);

            Console.WriteLine(result);
        }
    }
}
