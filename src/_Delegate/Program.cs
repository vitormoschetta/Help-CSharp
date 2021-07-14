using System;
using System.Threading;


namespace _Delegate
{

    /* 
    Delegados são usados para passar métodos como argumentos a outros métodos. 
    Para que isse seja possível, os delagados podem ser armazenados como uma variável.

    A única observação é que o delagado precisa ser declarado com a mesma assinatura do(s) método(s) que ele irá receber como valor.
    
    Essa capacidade de se referir a um método como um parâmetro torna delegados ideais trabalhar com callback, ou promessas. 
    Ou seja passar uma funcionalidade inteira como parâmetro para uma outra rotina, para que em um momento determinado o delegado 
    seja invocado e execute a funcionalidade que de outra forma estaria fora do escopo.
    */

    // Observe este exemplo e delegate:
    public delegate decimal DelCalc(decimal x, decimal y, char operation);

    // O delegate acima pode ser utilizado para armazenar qualquer método que receba dois deimais e um char e retorne um decimal.

    public delegate void DelGenericValidate<T>(T item);

    class Program
    {
        static void Main(string[] args)
        {
            // Podemos criar atribuindo o método numa expressão lambda:

            DelCalc delCalc = (x, y, operation) =>
            {
                switch (operation)
                {
                    case '+':
                        return x + y;
                    case '-':
                        return x - y;
                    case '*':
                        return x * y;
                    case '/':
                        return x / y;
                    default:
                        return x + y;
                }
            };

            Calculator(delCalc, 5, 2, '*');


            // Podemos passar ao delegate um método já existente:

            DelCalc delCalc1 = new Calculator().GenericCalc;
            Calculator(delCalc1, 7, 13, '+');

            Teste();
        }

        static void Calculator(DelCalc delCalc, decimal x, decimal y, char operation)
        {
            Thread.Sleep(1000);
            var result = delCalc.Invoke(x, y, operation);
            Console.WriteLine(result);
        }

        static void Teste()
        {
            DelGenericValidate<string> delGenericValidate = mensagem =>
            {
                Console.WriteLine(mensagem);
            };

            delGenericValidate.Invoke("Teste mensagem");
        }
    }
}
