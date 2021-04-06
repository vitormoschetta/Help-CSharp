using System;

namespace dll
{
    public class Metodos
    {
        public static decimal Result { get; set; }
        public static void Somar(decimal x, decimal y)
        {
            Result = x + y;
            Console.WriteLine(Result);
        }

        public static void Subtrair(decimal x, decimal y)
        {
            Result = x - y;
            Console.WriteLine(Result);
        }
    }
}
