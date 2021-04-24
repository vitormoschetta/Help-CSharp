using System;
using System.Threading;
using _Delegate.Services;

namespace _Delegate
{

    /* 
    Delegados são usados para passar métodos como argumentos a outros métodos.         
    Esclarecendo, delagado é um tipo de variável que recebe um método como valor. 

    A única observação é que o delagado precisa ser declarado com a mesma assinatura do(s) método(s) que ele irá receber como valor. Ou seja,
    deve conter a mesma assinatura de método.
    
    Essa capacidade de se referir a um método como um parâmetro torna delegados ideais trabalhar com callback, ou promessas. Ou seja
    passar uma funcionalidade inteira como parâmetro parar uma outra rotina, para que em um momento determinado o delegado seja invocado e execute
    a funcionalidade que de outra forma estaria fora do escopo.
    */

    // Observe este exemplo e delegate abaixo:
    public delegate void DelMyDel(decimal x, decimal y);    

    // Este delegado pode ser utilizado para receber como valor qualquer método que receba dois números decimais, e retorne um decimal.     
    
        
    class Program
    {        
        static void Main(string[] args)
        {             
            // Instancia o delegate informando um método existente:

            DelPrint delPrint = new Printer().PublicPrint();
            Printer(delPrint);

            DelCalcGeneric delCalc = new Calculator().GenericCalc;
            Calculator(delCalc);          


            // Instancia o delegate criando um método:
            DelMyDel delMyDel = delegate(decimal x, decimal y) { Console.WriteLine(x + y); };
            delMyDel.Invoke(2,9);

            // Instancia o delegate criando um método utilizando lambda expression:
            DelMyDel delMyDel102 = (x,y) => { Console.WriteLine(x + y); };
            delMyDel102.Invoke(55,1);
        }


        static void Printer(DelPrint delPrint)
        {
            Thread.Sleep(1000);
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
