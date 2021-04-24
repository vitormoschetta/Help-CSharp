using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Degug
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
                Calculadora.Divider(5,0);
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
            }

        }
    }

}
