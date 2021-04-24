using System;

namespace _Lambda
{

    // Na classe que se segue, além do método Main, existem outras três funções que 
    // fazem a mesma coisa..


    class Program
    {
        private static int result;
        static void Main(string[] args)
        {
            result = CalcSquareA(5);
            Console.WriteLine(result);

            result = CalcSquareB(5);
            Console.WriteLine(result);

            result = CalcSquareC.Invoke(5);
            Console.WriteLine(result);
        }



        // Sintaxe mais comum, como a maioria dos programadores estão acostumados:
        static int CalcSquareA(int x)
        {
            return x * x;
        }



        // Sintaxe de função utilizando Expressão Lambda:
        static Func<int, int> CalcSquareB = x => x * x;        



        // Sintaxe utilizando delegate     
        static DelCalcSquare CalcSquareC = (x) => { return x * x; };

        // Para o caso acima é preciso declarar um delegate:
        public delegate int DelCalcSquare(int x);


    }
}
