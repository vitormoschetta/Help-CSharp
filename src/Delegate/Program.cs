using System;
using Delegate;

namespace delegado
{

    // Delegados são usados para passar métodos como argumentos a outros métodos.
    // Essa capacidade de se referir a um método como um parâmetro torna delegados ideais para definir métodos de retorno de chamada. 

    class Program
    {
        static void Main(string[] args)
        {            
            DelCalc delCalcSoma = Calculadora.Somar;
            Console.WriteLine(delCalcSoma.Invoke(2,3));

            DelCalc delCalcMult = Calculadora.Multiplicar;
            Console.WriteLine(delCalcMult.Invoke(2,3));

            DelImprimir delPrint = Impressora.ImprimirPublic();
            delPrint.Invoke();
        }
    }

}
