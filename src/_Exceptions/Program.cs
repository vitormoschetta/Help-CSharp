using System;

namespace _Exceptions
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new Exception("Não é possível dividir um número por zero");
            }                
            return x / y;
        }

        static void Main(string[] args)
        {
            double a = 98, b = 0;
            double result;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch 
            {                
                throw;
                // utilizar apenas 'throw' nas camadas superiores nos fornece um rastreamento de pilha mais completo
            }
            finally
            {
                Console.WriteLine("Esse bloco sempre irá executar, independente se houve exceção ou não..");
                // Esse bloco é excelente para desfazer operações iniciadas, liberar recursos, ou executar algo
                // que independe da ocorrência de exceção..
            }

        }
    }
}
