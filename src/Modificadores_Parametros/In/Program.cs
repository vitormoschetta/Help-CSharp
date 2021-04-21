using System;

namespace In
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            RaizQuadrada(number);            
        }


        // A palavra reservadad 'in' nos informa que esse argumento 'number' foi passado como
        // referência mas bloqueia a modificação de seu valor. 
        static int RaizQuadrada(in int number)
        {
            // number = number * number;    <-- isso não funcionaria.
            // A única utilidade da variável 'number' aqui seria servir de referência para outros processos e/ou 
            // métodos e variáveis.

            Console.WriteLine(number * number);
        }


        // aqui a variável 'number' não é passada como referência, logo pode ser modificada.
        static void RaizQuadradaNormal(int number)
        {                        
            number = number * number;            
        }
    }
}
