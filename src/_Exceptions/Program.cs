using System;

namespace _Exceptions
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("Não é possível dividir um núemro por zero");
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
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
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
