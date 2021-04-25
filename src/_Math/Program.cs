using System;

namespace _Math
{
    // Math fornece constantes e métodos estáticos para funções de trigonométria, logarítmicas e outras
    // funções matemáticas comuns.
    class Program
    {
        static void Main(string[] args)
        {         
            Console.Write("\nDiferença sempre em inteiro: ");
            Console.WriteLine(Math.Abs(5 - 15));

            Console.Write("\nArredondamento: para inteiro: ");
            Console.WriteLine(Math.Round(5.424878));
            
            Console.Write("\nArredondamento: arredondado para duas casas decimas: ");
            Console.WriteLine(Math.Round(5.524878, 2));

            Console.Write("\nPotência: resultado de x elevado a y: ");
            Console.WriteLine(Math.Pow(2, 3));

            Console.Write("\nBit: incremento e decremento de bit sobre o numero 9: ");
            Console.Write(Math.BitIncrement(9));
            Console.Write(" | ");
            Console.WriteLine(Math.BitDecrement(9));

            Console.Write("\nRetorna o menor valor inteiro maior que o decimal parametro especificado: ");
            Console.WriteLine(Math.Ceiling(3.4545));

            Console.Write("\nRetorna o valor mais próximo do mínimo ou o valor maior próximo do máximo especificados: ");
            Console.WriteLine(Math.Clamp(10,8,9));
        }
    }
}
