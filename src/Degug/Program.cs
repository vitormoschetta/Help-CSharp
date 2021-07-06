using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Degug
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 5;
            var resultado = 1L;

            for (int i = valor; i >= 2; i--)
               resultado *= i;

            Console.WriteLine(resultado);
        }       
    }
}
