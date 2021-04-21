using System;
using System.Threading;
using delegado.Services;
using Delegate;
using Delegate.Services;

namespace delegado
{

    // Delegados são usados para passar métodos como argumentos a outros métodos.
    // Na verdade, delagado é um tipo de variável que recebe um método como valor. 
    // A única observação é que o delagado precisa ser declarado com a mesma assinatura do(s) método(s) que ele irá receber como valor.
    // Essa capacidade de se referir a um método como um parâmetro torna delegados ideais trabalhar com callback, ou promessas. Ou seja
    // passar uma funcionalidade inteira como parâmetro parar uma outra rotina, para que um momento X o delegado seja invocado e execute
    // a funcionalidade que de outra forma estaria fora do escopo.

    // Veja, o delegado pode ser utilizado para receber como valor qualquer método que receba dois números decimais, e retorne um decimal.    
    public delegate decimal DelMyDel(decimal x, decimal y);     
        
    class Program
    {        
        static void Main(string[] args)
        {             
            DelPrint delPrint = new Printer().PublicPrint();
            Printer(delPrint);

            DelCalcGeneric delCalc = new Calculator().GenericCalc;
            Calculator(delCalc);
        }


        static void Printer(DelPrint delPrint)
        {
            Thread.Sleep(3000);
            delPrint.Invoke();
        }


        static void Calculator(DelCalcGeneric delCalc)
        {
            Thread.Sleep(1000);
            var result = delCalc.Invoke(2,5, '*');
            Console.WriteLine(result);
        }

        

        
    }

    

}
